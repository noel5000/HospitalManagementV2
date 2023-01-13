﻿
namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ControllerAuthorize(Common.Enums.Controllers.Role)]
    [ApiController]
    public class RoleController : BaseController<Role>
    {
        public RoleController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache, null, Common.Enums.Controllers.Role)
        {
        }
    }
}