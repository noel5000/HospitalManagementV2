using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using NPOI.SS.Formula.Functions;
using PointOfSalesV2.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using Log = Serilog.Log;
using Microsoft.Extensions.Options;
using PointOfSalesV2.Entities.Model;

namespace PointOfSalesV2.EntityFramework
{
    public class TenantService : ITenantService
    {
        private readonly IHttpContextAccessor _HttpContextAccessor;
        private readonly IOptions<AppSettings> _appSettings;
        public TenantService(
            IHttpContextAccessor httpContextAccessor,
            IOptions<AppSettings> appSettings
            )
        {
            this._appSettings = appSettings;
            this._HttpContextAccessor = httpContextAccessor;
        }
        public string Tenant => this.GetTenant();


        public string GetTenant()
        {
            StringValues tenantId = new StringValues();
            this._HttpContextAccessor?.HttpContext?.Request?.Headers?.TryGetValue("x-api-key", out tenantId);
            if (string.IsNullOrEmpty(tenantId))
            {
                Log.Error("Api Key required");
                tenantId = "";
                // throw new Exception("Api Key required");
            }
            return MD5.Decrypt(tenantId.ToString().Split(" ").LastOrDefault() ?? tenantId, _appSettings.Value.TokenKey);
        }

    }
}
