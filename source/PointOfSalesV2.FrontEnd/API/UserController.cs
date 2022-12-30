﻿

namespace PointOfSalesV2.FrontEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.Users)]
    public class UserController :ControllerBase
    {
        protected readonly IDataRepositoryFactory _repositoryFactory;
        protected readonly IOptions<AppSettings> _appSettings;
        protected readonly IUserRepository _baseRepo;
        public UserController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory)
        {
            _appSettings = appSettings;
            _repositoryFactory = repositoryFactory;
            this._baseRepo = _repositoryFactory.GetCustomDataRepositories<IUserRepository>();
        }


        [HttpGet]
        [ActionAuthorize(Operations.READALL)]
        [EnableQuery]
        [Microsoft.AspNetCore.OData.Routing.Attributes.ODataAttributeRouting]
        [EnableCors("AllowAllOrigins")]
        public virtual async Task<IActionResult> Get()
        {
            try
            {
                var data =await _baseRepo.GetAllAsync<User>(x => x.Where(y =>y.UserId.ToString()!=new Guid().ToString()));
                return Ok(data);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpGet("{id}")]
        //[EnableQuery]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.READ)]
        public virtual async Task<IActionResult> GetById(string id)
        {
            try
            {
                var data = await _baseRepo.GetAsync(new Guid(id));
                return Ok(data);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        






        [HttpPost]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.ADD)]
        public virtual async Task<IActionResult> Post([FromBody] User model)
        {
            try
            {
                var activeEntity = model as ICommonData;
                if (activeEntity != null)
                {
                    activeEntity.Active = true;
                    model = activeEntity as User;
                }
                var result = await _baseRepo.AddAsync(model);

                return Ok(result);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }

        }

        [HttpPut]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.UPDATE)]
        public virtual async Task<IActionResult> Put([FromBody] User model)
        {
            try
            {
                var result = await _baseRepo.UpdateAsync(model);
                return Ok(result);
            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }

        }

        [HttpDelete("{id}")]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.DELETE)]
        public virtual async Task<IActionResult> Delete(string id)
        {
            try
            {
                var model = (await _baseRepo.GetAsync(new Guid(id))).Data.FirstOrDefault() as ICommonData;
                if (model != null)
                {
                    model.Active = false;
                    var result = await _baseRepo.UpdateAsync(model as User);
                    return Ok(result);
                }
                else
                {
                    return Ok(new { status = -1, message = "error_msg" });
                }

            }

            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });

            }

        }

        protected virtual IBase<K> GetDataRepo<K>() where K : class, ICommonData, new()
        {
            return _repositoryFactory.GetDataRepositories<K>();
        }
    }
}