using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public interface IRoleSectionOperationRepository : IBase<RoleSectionOperation>
    {
        Task<IQueryable<RoleSectionOperation>> GetWithAllChildren();
    }
}
