﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PointOfSalesV2.Api.Security;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities; using Microsoft.Extensions.Caching.Memory;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.Repository;
using static PointOfSalesV2.Common.Enums;
using Microsoft.AspNetCore.Cors;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.Products)]
    public class ProductController : BaseController<Product>
    {
        readonly IProductRepository _customRepo;
        public ProductController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache
            , repositoryFactory.GetCustomDataRepositories<IProductRepository>(), AppSections.Products)
        {
            _customRepo = repositoryFactory.GetCustomDataRepositories<IProductRepository>();
        }

        [HttpGet]
        [ActionAuthorize(Operations.READALL)]
        [EnableQuery()]
        [EnableCors("AllowAllOrigins")]
        public override async Task<IActionResult> Get()
        {
            try
            {
                var data = await _baseRepo.GetAllAsync<Product>(x => x.Include(t => t.Currency).Include(x=>x.MedicalSpeciality)
                 , y => y.Active == true);
                return Ok(data);
               
            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }


        [HttpPost]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.ADD)]
        public override async Task<IActionResult> Post([FromBody] Product model)
        {
            try
            {
                var activeEntity = model as ICommonData;
                if (activeEntity != null)
                {
                    activeEntity.Active = true;
                    model = activeEntity as Product;
                }
                var result = await _customRepo.AddAsync(model);
                result.Data = null;
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
        public override async Task<IActionResult> Put([FromBody] Product model)
        {
            try
            {
                var result = await _customRepo.UpdateAsync(model);
                return Ok(result);
            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }

        }

        [HttpPost("ExportToExcel")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.EXPORT)]
        public override async Task<IActionResult> ExportToExcel()
        {
            try
            {
                var data = await _baseRepo.GetAllAsync<Product>(x => x.Include(t => t.Currency)
                 , y => y.Active == true);
                string requestLanguage = "EN";
                var languageIdHeader = this.Request.Headers["languageid"];
                requestLanguage = languageIdHeader.FirstOrDefault() ?? "ES";
                var excelData = ExportUtility.GetExcelData<Product>(data, requestLanguage, this.languageKeys.ToList());
                var excelStream = ExcelImport.CreateXlsStream(
                    excelData.Item1,
                   excelData.Item2
                   );
                if (data != null && excelStream != null && excelStream.Length > 0)
                {

                    return File(excelStream.ToArray(), "application/octet-stream", $"{new Product().GetType().Name}-{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}.xls");
                }
                return BadRequest(new { status = -1, message = "documentDoesntExist_msg" });


            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }
    }
}