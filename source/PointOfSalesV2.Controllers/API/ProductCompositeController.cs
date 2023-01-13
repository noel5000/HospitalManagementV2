﻿

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ControllerAuthorize(Common.Enums.Controllers.Product)]
    [ApiController]
    public class ProductCompositeController : BaseController<CompositeProduct>
    {
        public ProductCompositeController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache, null, Common.Enums.Controllers.Product)
        {
        }

        [HttpPost]
        [EnableCors("AllowAllOrigins")]
        public override async Task<IActionResult> Post([FromBody] CompositeProduct model)
        {
            return BadRequest(new { Status = -1, Message = "notValid_msg" });
        }


        [HttpPut]
        [EnableCors("AllowAllOrigins")]
        public override async Task<IActionResult> Put([FromBody] CompositeProduct model)
        {
            return BadRequest(new { Status = -1, Message = "notValid_msg" });
        }
    }
}