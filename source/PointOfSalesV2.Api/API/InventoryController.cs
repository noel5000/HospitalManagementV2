using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PointOfSalesV2.Api.Security;
using PointOfSalesV2.Entities; using Microsoft.Extensions.Caching.Memory;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.Repository;
using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Api.Models;
using static PointOfSalesV2.Common.Enums;
using PointOfSalesV2.Common;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.OData.Query;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.Inventories)]
    public class InventoryController : BaseController<Inventory>
    {
        readonly IInventoryRepository inventoryRepository;
        public InventoryController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,null, AppSections.Inventories)
        {
            this.inventoryRepository = repositoryFactory.GetCustomDataRepositories<IInventoryRepository>();
        }

        [HttpGet]
        [ActionAuthorize(Operations.READALL)]
        [EnableQuery]
        [Microsoft.AspNetCore.OData.Routing.Attributes.ODataAttributeRouting]
        [EnableCors("AllowAllOrigins")]
        public override async Task<IActionResult> Get()
        {
            try
            {
                var data = await _baseRepo.GetAllAsync<Inventory>(x => x.AsNoTracking().Include(i=>i.BranchOffice)
                .Include(i => i.Product).Include(i => i.Warehouse).Include(i => i.Unit), y => y.Active == true);
                return Ok(data);
            }

            catch (Exception ex)
            {
                await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpPatch("GetCompanyInventory/{branchOfficeId:long}/{warehouseId:long}/{productId:long}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Common.Enums.Operations.INVENTORYREPORT)]
       public async Task<IActionResult> GetCompanyInventory(long branchOfficeId = 0, long warehouseId = 0,long productId=0) 
        {
            try
            {
                var result=this.inventoryRepository.GetCompanyInventory(branchOfficeId,warehouseId,productId);
                

                    return Ok(new { id = 0, status = 0, message = "ok_msg", data = result });
            }
            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { id = -1, status = -1, message = "error_msg" });
            }
        }



        [HttpPost("ExportToExcel/{branchOfficeId:long}/{warehouseId:long}/{productId:long}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.INVENTORYREPORT)]
        public  async Task<IActionResult> ExportToExcel(long branchOfficeId = 0, long warehouseId = 0, long productId = 0)
        {
            try
            {
                var data = await _baseRepo.GetAllAsync<Inventory>(x => x.Include(i => i.Product)
                .Include(i => i.Warehouse)
                .Include(i => i.BranchOffice)
                .Include(i => i.Unit)
                 , y => y.Active == true
                  && (branchOfficeId > 0 ? y.BranchOfficeId == branchOfficeId : y.BranchOfficeId > 0)
                  && (warehouseId > 0 ? y.WarehouseId == warehouseId : y.WarehouseId > 0)
                  && (productId > 0 ? y.ProductId == productId : y.ProductId > 0));
                string requestLanguage = "EN";
                var languageIdHeader = this.Request.Headers["languageid"];
                requestLanguage = languageIdHeader.FirstOrDefault() ?? "ES";
                var excelData = ExportUtility.GetExcelData<Inventory>(data, requestLanguage, this.languageKeys.ToList());
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