using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text; using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public interface IWarehouseTransferRepository: IBase<WarehouseTransfer>
    {
        Task<Result<object>> AddTransfersList(List<WarehouseTransfer> entries, string reference, string details);
       Task<Result<object>> RemoveTransfers(string sequence);
    }
}
