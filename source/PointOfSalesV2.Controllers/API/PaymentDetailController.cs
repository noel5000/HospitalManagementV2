﻿

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.Controllers.CustomerPayment)]
    public class PaymentDetailController : BaseController<PaymentDetail>
    {
        public PaymentDetailController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : 
            base(appSettings, repositoryFactory,cache,null, Common.Enums.Controllers.CustomerPayment)
        {
        }
    }
}