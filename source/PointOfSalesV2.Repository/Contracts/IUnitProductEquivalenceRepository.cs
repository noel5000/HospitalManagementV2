using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text; using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public interface IUnitProductEquivalenceRepository : IBase<UnitProductEquivalence>
    {
        Task<IEnumerable<UnitProductEquivalence>> GetProductUnits(long productId);
    }
}
