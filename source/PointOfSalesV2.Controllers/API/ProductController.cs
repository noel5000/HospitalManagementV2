

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.Controllers.Product)]
    public class ProductController : BaseController<Product>
    {
        readonly IProductRepository _customRepo;
        public ProductController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory, cache
            , repositoryFactory.GetCustomDataRepositories<IProductRepository>(), Enums.Controllers.Product)
        {
            _customRepo = repositoryFactory.GetCustomDataRepositories<IProductRepository>();
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
                var data = await _baseRepo.GetAllAsync<Product>(x => x.AsNoTracking()
                .Include(t => t.Currency)
                .Include(x => x.MedicalSpeciality)
                .Include(x => x.Currency)
                .Include(x => x.BaseCompositeProducts).ThenInclude(b => b.BaseProduct)
                .Include(x => x.ProductUnits).ThenInclude(u=>u.Unit)
                .Include(x => x.SuppliersCosts).ThenInclude(s=>s.Supplier)
                .Include(x => x.Taxes).ThenInclude(s => s.Tax)
                 , y => y.Active == true);
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
        public override async Task<IActionResult> Post([FromBody] Product model)
        {
            try
            {
                var activeEntity = model as ICommonData;
                if (activeEntity != null)
                {
                    activeEntity.Active = true;
                    model = activeEntity as Product;
                }
                var result = await _customRepo.AddAsync(model);
                result.Data = null;
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
        public override async Task<IActionResult> Put([FromBody] Product model)
        {
            try
            {
                var result = await _customRepo.UpdateAsync(model);
                return Ok(result);
            }

            catch (Exception ex)
            {
                await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }

        }

        [HttpPost("ExportToExcel")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.EXPORT)]
        [Microsoft.AspNetCore.OData.Routing.Attributes.ODataAttributeRouting]
        public override async Task<IActionResult> ExportToExcel()
        {
            try
            {
                var data = await _baseRepo.GetAllAsync<Product>(x => x.AsNoTracking()
                .Include(t => t.Currency)
                .Include(x => x.MedicalSpeciality)
                .Include(x => x.Currency)
                .Include(x => x.BaseCompositeProducts).ThenInclude(b => b.BaseProduct)
                .Include(x => x.ProductUnits).ThenInclude(u => u.Unit)
                .Include(x => x.SuppliersCosts).ThenInclude(s => s.Supplier)
                .Include(x => x.Taxes).ThenInclude(s => s.Tax)
                 , y => y.Active == true);
                string requestLanguage = "EN";
                var languageIdHeader = this.Request.Headers["languageid"];
                requestLanguage = languageIdHeader.FirstOrDefault() ?? "ES";
                var excelData = ExportUtility.GetExcelData<Product>(data, requestLanguage, this.languageKeys.ToList());
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