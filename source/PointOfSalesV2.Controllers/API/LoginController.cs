

using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using PointOfSalesV2.Repository.Helpers;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PointOfSalesV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IOptions<AppSettings> _appSettings;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMemoryCache _cache;
        private readonly IBase<User> users;
        private readonly IDataRepositoryFactory dataRepositoryFactory;
        private readonly IUserRepository userRepository;

        public LoginController(IMemoryCache cache, IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IHttpContextAccessor httpContextAccessor)
        {
            this._appSettings = appSettings;
            this._httpContextAccessor = httpContextAccessor;
            this._cache = cache;
            this.users = repositoryFactory.GetDataRepositories<User>();
            this.dataRepositoryFactory = repositoryFactory;
            this.userRepository = this.dataRepositoryFactory.GetCustomDataRepositories<IUserRepository>();
        }

        [HttpPost]
        [AllowAnonymous]
       public async Task<IActionResult> Post([FromBody] Login model)
        {
            try
            {
                UsersHelper.VerifyAdminUser(this.dataRepositoryFactory);
                User user = await userRepository.Login(model, _appSettings.Value.TokenKey);
                if (user == null  || string.IsNullOrEmpty( user.TenantId))
                    return Ok(new { status = -1, message = "Invalid credentials" });

                var issuer = _appSettings.Value.Domain;
                var audience = _appSettings.Value.Domain;
                var expiration = DateTime.UtcNow.AddHours(_appSettings.Value.TokenTimeHours);
                var key = Encoding.ASCII.GetBytes
                (_appSettings.Value.TokenKey);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[]
                    {
                new Claim("Id", user.UserId.ToString()),
                new Claim(JwtRegisteredClaimNames.Name, user.UserName),
                new Claim("TenantId", MD5.Encrypt( user.TenantId, _appSettings.Value.TokenKey)),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("Permissions",JsonConvert.SerializeObject(user.Permissions)),
                new Claim(JwtRegisteredClaimNames.Jti,
                user.UserId.ToString().ToString())
             }),
                    Expires = expiration,
                    Issuer = issuer,
                    Audience = audience,
                    SigningCredentials = new SigningCredentials
                    (new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha512Signature)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.CreateToken(tokenDescriptor);
                var jwtToken = tokenHandler.WriteToken(token);
                var stringToken = tokenHandler.WriteToken(token);
                user.TokenKey = stringToken;
                return Ok(new
                {
                    message = "OK",
                    status = 1,
                    token = stringToken,
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
                       
                    if (!_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
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