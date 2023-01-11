

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.ExpensesPayments)]
    public class ExpensesPaymentController : BaseController<ExpensesPayment>
    {
        readonly IExpensesPaymentRepository _repo;
        public ExpensesPaymentController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory, cache, null, AppSections.ExpensesPayments)
        {
            this._repo = _repositoryFactory.GetCustomDataRepositories<IExpensesPaymentRepository>();
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
                var data = await _repo.GetAllAsync<ExpensesPayment>(x => x
                .Include(x => x.Supplier)
                .Include(x => x.Currency)
                .Include(x => x.ExpenseCurrency)
                .Include(x => x.Expense)
                .Include(x => x.PaymentType)
                .Where(y => y.Active == true));
                return Ok(data);
            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpGet("{id:long}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.READ)]
        public override async Task<IActionResult> GetById(long id)
        {
            try
            {
                var data = await _repo.GetAsync(id);
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
        public override async Task<IActionResult> Post([FromBody] ExpensesPayment model)
        {
            try
            {
                var activeEntity = model as ICommonData;
                if (activeEntity != null)
                {
                    activeEntity.Active = true;
                    model = activeEntity as ExpensesPayment;
                }
                var result = await _repo.AddAsync(model);

                return Ok(result);
            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }

        }

        [HttpPost("AddPayments")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.ADD)]
       public async Task<IActionResult> AddPayments([FromBody] ExpensesPaymentModel model)
        {
            try
            {
                if (model.Expenses == null || model.Expenses.Count == 0)
                    throw new Exception("error_msg");
                var result = await _repo.AddPayment(model.Payment, model.Expenses);

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
        public override async Task<IActionResult> Put([FromBody] ExpensesPayment model)
        {
            try
            {
                var result = await _repo.UpdateAsync(model);
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
                var result = await _repo.RemoveAsync(id);
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