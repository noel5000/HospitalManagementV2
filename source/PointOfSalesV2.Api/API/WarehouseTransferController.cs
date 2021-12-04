
using PointOfSalesV2.Api.Models;


namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigins")]
    [ControllerAuthorize(Common.Enums.AppSections.WarehouseTransfers)]
    public class WarehouseTransferController : BaseController<WarehouseTransfer>
    {
        readonly IWarehouseTransferRepository repo;
        public WarehouseTransferController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache, IWarehouseTransferRepository repo) : base(appSettings, repositoryFactory,cache, repo, Common.Enums.AppSections.WarehouseTransfers)
        {
            this.repo = repositoryFactory.GetCustomDataRepositories<IWarehouseTransferRepository>();
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
                var data = await _baseRepo.GetAllAsync<WarehouseTransfer>(x => x
                .Include(x => x.OriginBranchOffice)
                .Include(x => x.DestinyBranchOffice)
                .Include(x => x.Unit)
                .Include(x => x.Product)
                .Include(x => x.Destiny)
                .Include(x => x.Origin)
                .Where(y => y.Active == true));
                return Ok(data);
            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpPost("AddEntries")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.ADD)]
       public async Task<IActionResult> AddEntries([FromBody]WarehouseTransferModel model)
        {
            try
            {
                var result = await repo.AddTransfersList(model.Entries, model.Reference, model.Details);
                return Ok(result);
            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }

        }

        [HttpDelete("DeleteEntries/{sequence}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.DELETE)]
       public async Task<IActionResult> DeleteEntries(string sequence)
        {
            try
            {
                var result = await repo.RemoveTransfers(sequence);
                return Ok(result);
            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });

            }

        }
    }
}