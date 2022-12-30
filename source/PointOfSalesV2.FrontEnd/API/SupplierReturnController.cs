﻿

using PointOfSalesV2.FrontEnd.Models;

namespace PointOfSalesV2.FrontEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.SuppliersReturns)]
    public class SupplierReturnController : BaseController<SupplierReturn>
    {
        ISupplierReturnRepository repo;
        public SupplierReturnController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,repositoryFactory.GetCustomDataRepositories<ISupplierReturnRepository>(), AppSections.SuppliersReturns)
        {
            this.repo = repositoryFactory.GetCustomDataRepositories<ISupplierReturnRepository>();
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
                var data = await _baseRepo.GetAllAsync<SupplierReturn>(x => x.Include(t => t.Currency)
                .Include(t => t.BranchOffice)
                .Include(t => t.Warehouse)
                .Include(t => t.Product)
                .Include(t => t.Unit)
                .Include(t => t.Supplier)
                , y => y.Active == true);
                return Ok(data);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }


        [HttpPost("AddEntries")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.ADD)]
       public async Task<IActionResult> AddEntries([FromBody]SupplierReturnModel model)
        {
            try
            {
                var result = await repo.AddInventoryList(model.Entries, model.Reference, model.Details);
                return Ok(result);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }

        }

        [HttpDelete("DeleteEntries/{sequence}")]
        [ActionAuthorize(Operations.DELETE)]
        [EnableCors("AllowAllOrigins")]
       public async Task<IActionResult> DeleteEntries(string sequence)
        {
            try
            {
                var result = await repo.RemoveEntries(sequence);
                return Ok(result);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });

            }

        }
    }
}