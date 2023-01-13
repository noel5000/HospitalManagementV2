global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Security.Cryptography.X509Certificates;
global using System.Threading.Tasks;
global using Microsoft.AspNetCore.OData.Query;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.Extensions.Caching.Memory;
global using Microsoft.Extensions.Options;

global using PointOfSalesV2.Common;
global using PointOfSalesV2.Entities;
global using PointOfSalesV2.Entities.Model;
global using PointOfSalesV2.Repository;
global using static PointOfSalesV2.Common.Enums;
global using Microsoft.AspNetCore.Cors;
global using Microsoft.EntityFrameworkCore;

namespace PointOfSalesV2.Controllers
{

    //   ODataController\

    public abstract class BaseController<T> : ControllerBase where T : class, ICommonData, new()
    {
        protected readonly IDataRepositoryFactory _repositoryFactory;
        protected readonly IOptions<AppSettings> _appSettings;
        protected readonly IBase<T> _baseRepo;
        protected readonly IMemoryCache _cache;
        protected readonly IBase<LanguageKey> languageKeysRepo;
        protected readonly IBase<ExceptionLog> exceptionsRepo;
        protected IEnumerable<LanguageKey> languageKeys;
        protected readonly Enums.Controllers section;
        public BaseController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache, IBase<T> customRepo = null, Enums.Controllers appSections = Enums.Controllers.NotSpecified)
        {
            this._cache = cache;
            _appSettings = appSettings;
            _repositoryFactory = repositoryFactory;
            this.languageKeysRepo = repositoryFactory.GetDataRepositories<LanguageKey>();
            this.languageKeys = _cache.Get<IEnumerable<LanguageKey>>("languageKeysMem");
            if (this.languageKeys == null)
            {
                this.languageKeys = this.languageKeysRepo.GetAll(x => x, y => y.Active == true).Data;
                this._cache.Set("languageKeysMem", this.languageKeys, DateTime.Now.AddHours(24));
            }
            this._baseRepo = customRepo ?? _repositoryFactory.GetDataRepositories<T>();
            this.exceptionsRepo = this._repositoryFactory.GetDataRepositories<ExceptionLog>();
            this.section = appSections;
        }

        [HttpGet]
        [ActionAuthorize(Operations.READALL)]
        [EnableQuery]
        [Microsoft.AspNetCore.OData.Routing.Attributes.ODataAttributeRouting]
        [EnableCors("AllowAllOrigins")]
        public virtual async Task<IActionResult> Get()
        {
            try
            {
                var data = await _baseRepo.GetAllAsync<T>(x => x.AsNoTracking(), y => y.Active == true);
                return Ok(data);
            }

            catch (Exception ex)
            {
                await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        protected async Task SaveException(Exception ex)
        {
            await this.exceptionsRepo.AddAsync(new ExceptionLog()
            {
                Code = ex.HResult.ToString(),
                Active = true,
                Message = ex.Message.Length > 500 ? ex.Message.Substring(0, 499) : ex.Message,
                Section = (int)this.section,
                SectionName = this.section.ToString()
            });
        }

        [HttpGet("ExportToExcel")]
        [ActionAuthorize(Operations.EXPORT)]
        [EnableQuery]
        [Microsoft.AspNetCore.OData.Routing.Attributes.ODataAttributeRouting]
        [EnableCors("AllowAllOrigins")]
        public virtual async Task< IActionResult> ExportToExcel()
        {
            try
            {
                var data =await _baseRepo.GetAllAsync<T>(x => x.AsNoTracking(),y=>y.Active==true);
                string requestLanguage = "EN";
                var languageIdHeader = this.Request.Headers["languageid"];
                requestLanguage = languageIdHeader.FirstOrDefault() ?? "es";
                var excelData = ExportUtility.GetExcelData<T>(data, requestLanguage,this.languageKeys.ToList());
                var excelStream = ExcelImport.CreateXlsStream(
                    excelData.Item1,
                   excelData.Item2
                   );
                if (data != null && excelStream != null && excelStream.Length > 0)
                {

                    return File(excelStream.ToArray(), "application/octet-stream", $"{new T().GetType().Name}-{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}.xls");
                }
                return BadRequest(new { status = -1, message = "documentDoesntExist_msg" });


            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpGet("{id:long}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.READ)]
        public virtual async Task<IActionResult> GetById(long id)
        {
            try
            {
                var data = await _baseRepo.GetAsync(id);
                return Ok(data);
            }

            catch (Exception ex)
            {
              await  SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }

       






        [HttpPost]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.ADD)]
        public virtual async Task<IActionResult> Post([FromBody] T model)
        {
            try
            {
                var activeEntity = model as ICommonData;
                if (activeEntity != null)
                {
                    activeEntity.Active = true;
                    model = activeEntity as T;
                }
                var result = await _baseRepo.AddAsync(model);

                return Ok(result);
            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }

        }

        [HttpPut]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.UPDATE)]
        public virtual async Task<IActionResult> Put([FromBody] T model)
        {
            try
            {
                var result = await _baseRepo.UpdateAsync(model);
                return Ok(result);
            }

            catch (Exception ex)
            {
              await  SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }

        }

        [HttpDelete("{id:long}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.DELETE)]
        public virtual async Task<IActionResult> Delete(long id)
        {
            try
            {
                var result = await _baseRepo.RemoveAsync(id);
                return Ok(result);
            }

            catch (Exception ex)
            {
              await  SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });

            }

        }

        protected virtual IBase<K> GetDataRepo<K>() where K : class, ICommonData, new()
        {
            return _repositoryFactory.GetDataRepositories<K>();
        }
    }
}