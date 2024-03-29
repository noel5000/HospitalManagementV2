﻿

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ControllerAuthorize(Common.Enums.Controllers.CustomerReturn)]
    [ApiController]
    public class CustomerReturnController : BaseController<CustomerReturn>
    {
        public CustomerReturnController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : 
            base(appSettings, repositoryFactory,cache, repositoryFactory.GetCustomDataRepositories<ICustomerReturnRepository>(), Common.Enums.Controllers.CustomerReturn)
        {
        }
    }
}