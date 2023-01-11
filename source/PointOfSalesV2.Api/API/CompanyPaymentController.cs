﻿

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.CompanyPayments)]
    public class CompanyPaymentController : BaseController<CompanyPayments>
    {
        public CompanyPaymentController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, ICompanyPaymentRepository _repo, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,_repo, AppSections.CompanyPayments)
        {
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
                var data = await _baseRepo.GetAllAsync<CompanyPayments>(x => x.Include(t=>t.Currency)
                .Include(t=>t.PaymentType)
                , y => y.Active == true);
                return Ok(data);
            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }
    }
}