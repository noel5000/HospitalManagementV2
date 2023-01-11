

using Microsoft.IdentityModel.Tokens;
using PointOfSalesV2.Repository.Helpers;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PointOfSalesV2.FrontEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IOptions<AppSettings> _appSettings;
        private readonly IMemoryCache _cache;
        private readonly IBase<User> users;
        private readonly IDataRepositoryFactory dataRepositoryFactory;
        private readonly IUserRepository userRepository;

        public LoginController(IMemoryCache cache, IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory)
        {
            this._appSettings = appSettings;
            this._cache = cache;
            this.users = repositoryFactory.GetDataRepositories<User>();
            this.dataRepositoryFactory = repositoryFactory;
            this.userRepository = this.dataRepositoryFactory.GetCustomDataRepositories<IUserRepository>();
        }

        [HttpPost]
        [EnableCors("AllowAllOrigins")]
       public async Task<IActionResult> Post([FromBody] Login model)
        {
            try
            {
                UsersHelper.VerifyAdminUser(this.dataRepositoryFactory);
                User user = await userRepository.Login(model, _appSettings.Value.TokenKey);
                if (user == null)
                    return Ok(new { status = -1, message = "Invalid credentials" });
                var claims = new[]
           {
                        new Claim(JwtRegisteredClaimNames.UniqueName, user.Email),
                        new Claim(JwtRegisteredClaimNames.Sid,  user.UserId.ToString()),
                        //new Claim("miValor", "Lo que yo quiera"),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                    };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.Value.TokenKey));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var expiration = DateTime.UtcNow.AddHours(_appSettings.Value.TokenTimeHours);

                JwtSecurityToken token = new JwtSecurityToken(
                     issuer: _appSettings.Value.Domain,
                     audience: _appSettings.Value.Domain,
                     claims: claims,
                     expires: expiration,
                     signingCredentials: creds
                     );
                string tokenString = new JwtSecurityTokenHandler().WriteToken(token);
                user.TokenKey = tokenString;
                _cache.Set<User>(tokenString, user, DateTimeOffset.Now.AddHours(_appSettings.Value.TokenTimeHours));
                return Ok(new
                {
                    message = "OK",
                    status = 1,
                    token = tokenString,
                    expiration = expiration,
                    user = user,
                    languageId=user.LanguageCode
                });
            }
            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpGet("VerifySession")]
        [EnableCors("AllowAllOrigins")]
       public async Task<IActionResult> VerifySession()
        {
            try
            {
                var currentToken = HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "Authorization").Value.ToString();
                if (string.IsNullOrEmpty(currentToken) ||  !currentToken.Contains("Bearer"))
                    return Ok(new { status = -1, message = "error_msg" });
                else
                {
                        string token = currentToken.Split(" ").LastOrDefault();
                    User user = _cache.Get<User>(token);
                    if (user == null)
                        return Ok(new { status = -1, message = "error_msg" });
                    else
                        return Ok(new { status = 0, message = "ok_msg" });
                }

               
            }
            catch (Exception ex)
            {
                return Ok(new { status = -1, message = ex.Message });
            }
        }
    }
}