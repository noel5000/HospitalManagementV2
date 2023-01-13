using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSalesV2.Common
{
    public interface ITenantService
    {
        string Tenant { get; }

        string GetTenant();

    }
}
