using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;
using PointOfSalesV2.Entities; using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static PointOfSalesV2.Common.Enums;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;

namespace PointOfSalesV2.Controllers
{

    public class ActionAuthorize : TypeFilterAttribute
    {
        public ActionAuthorize(Operations operation) : base(typeof(ActionRequirementFilter))
        {

            Arguments = new object[] { operation, new Operations[0] };
        }

        public ActionAuthorize(Operations[] operations) : base(typeof(ActionRequirementFilter))
        {

            Arguments = new object[] {Operations.NONE, operations };
        }




    }

    public class ActionRequirementFilter : IAuthorizationFilter
    {
        readonly Operations _operation;
        readonly Operations[] _operations;
        readonly IHttpContextAccessor _httpContextAccessor;
        readonly IMemoryCache _cache;

        public ActionRequirementFilter(Operations operation, Operations[] operations, IHttpContextAccessor httpContextAccessor, IMemoryCache cache)
        {
            _operation = operation;
            _operations = operations;
            _httpContextAccessor = httpContextAccessor;
            _cache = cache;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            try
            {
                bool isInvalid = false;
                var currentToken = _httpContextAccessor.HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "Authorization").Value.ToString();
                var currentPath = _httpContextAccessor.HttpContext.Request.Path.ToString().Split("/").ToList();
                int index = currentPath.IndexOf("api") + 1;
                index = index == 0 ? currentPath.IndexOf("odata") + 1 : index;
                string currentController = currentPath[index];
                if (string.IsNullOrEmpty(currentToken) || string.IsNullOrEmpty(currentController)
                    || !currentToken.Contains("Bearer") || !_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
                    isInvalid = true;

                if (!isInvalid)
                {
                    string token = currentToken.Split(" ").LastOrDefault();
                    var userOperations = !_httpContextAccessor.HttpContext.User.Claims.Any(x => x.Type == "Permissions") ? null :
                         JsonConvert.DeserializeObject<List<UserOperation>>(_httpContextAccessor.HttpContext.User.
                         Claims.First(x => x.Type == "Permissions").Value);
                    if (userOperations != null)
                    {
                        var operations = userOperations.Count() == 0 ? new List<UserOperation>() { new UserOperation() } :
                            (_operation != Operations.NONE ?
                            userOperations.Where(r => (r.Controllers.ToLower().Split(",").ToList().Contains(currentController.ToLower())
                            || r.Controllers == "*") && (r.OperationId == (int)_operation || r.OperationId == (int)Operations.ALL)) :
                            userOperations.Where(r => (r.Controllers.ToLower().Split(",").ToList().Contains(currentController.ToLower())
                            || r.Controllers == "*") && (_operations.ToList().FindIndex(p => p == (Operations)r.OperationId) >= 0 ||
                            _operations.ToList().FindIndex(t => t == Operations.ALL) >= 0)));

                        if (userOperations.Count() > 0 && (operations == null || operations.Count() == 0))
                            context.Result = new ForbidResult();
                    }

                }
                else
                    context.Result = new ForbidResult();
            }
            catch 
            {
                context.Result = new ForbidResult();
            }

          
        }
    }
}
