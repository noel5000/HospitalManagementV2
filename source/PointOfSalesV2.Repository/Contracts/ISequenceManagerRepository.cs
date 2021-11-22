using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text; using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public interface ISequenceManagerRepository : IBase<SequenceControl>
    {
        Task<string> CreateSequence(Enums.SequenceTypes sequenceCode);
    }
}
