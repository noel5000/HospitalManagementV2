﻿

namespace PointOfSalesV2.FrontEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.CashRegisterOpenings)]
    public class CashRegisterOpeningController : BaseController<CashRegisterOpening>
    {
        private readonly ICashRegisterOpeningRepository _repo;
        public CashRegisterOpeningController(ICashRegisterOpeningRepository repo, IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache, null, AppSections.CashRegisterOpenings)
        {
            this._repo = repo;
        }

        [HttpGet]
        [ActionAuthorize(new Operations[] { Operations.READALL, Operations.READ })]
        [EnableQuery]
        [Microsoft.AspNetCore.OData.Routing.Attributes.ODataAttributeRouting]
        [EnableCors("AllowAllOrigins")]
        public override async Task<IActionResult> Get()
        {
            try
            {
                var data = await _repo.GetAllAsync<CashRegisterOpening>(x => x.Include(x => x.BranchOffice)
                .Include(x => x.User)
                .Include(x => x.CashRegister)
                .Include(x => x.Currency)
                .Where(y => y.Active == true));
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
        public override async Task<IActionResult> Post([FromBody] CashRegisterOpening model)
        {
            try
            {
                var activeEntity = model as ICommonData;
                if (activeEntity != null)
                {
                    activeEntity.Active = true;
                    model = activeEntity as CashRegisterOpening;
                }
                var result =await _repo.AddAsync(model);

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
        public override async Task<IActionResult> Put([FromBody] CashRegisterOpening model)
        {
            try
            {
                var result =await _repo.UpdateAsync(model);
                return Ok(result);
            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }

        }

        [HttpPut("CloseCashRegister")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.UPDATE)]
        public virtual async Task<IActionResult> CloseCashRegister([FromBody] CashRegisterOpening model)
        {
            try
            {
                var result = await _repo.Closure(model);
                return Ok(result);
            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }

        }

        [HttpDelete("{id:long}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.DELETE)]
        public override async Task<IActionResult> Delete(long id)
        {
            try
            {
                var model = (await _baseRepo.GetAsync(id)).Data.FirstOrDefault();
                if (model != null && model.State ==(char) Enums.CashRegisterOpeningStates.Open)
                {
                    model.State = (char)Enums.CashRegisterOpeningStates.Nulled;
                    var result = await _baseRepo.UpdateAsync(model as CashRegisterOpening);
                    return Ok(result);
                }
                else 
                {
                    if(model==null)
                    return Ok(new { status = -1, message = "error_msg" });
                    else
                    return Ok(new { status = -1, message = "cashRegisterOpeningIsClosed_msg" });
                }

            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });

            }

        }
    }
}