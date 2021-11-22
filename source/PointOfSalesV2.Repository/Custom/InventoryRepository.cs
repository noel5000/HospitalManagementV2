using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text; using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PointOfSalesV2.Repository
{
    public class InventoryRepository : Repository<Inventory>, IInventoryRepository
    {
        public InventoryRepository(MainDataContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Inventory>> GetBranchOfficeInventory(long branchOfficeId, long? productId)
        {

            return await _Context.Inventory.Include(x=>x.BranchOffice).Include(x=>x.Product).Include(x=>x.Unit).AsNoTracking().Where(
                inventory => inventory.Active == true && (productId.HasValue ? inventory.ProductId == productId.Value : inventory.Id > 0) &&
            inventory.BranchOfficeId == branchOfficeId
                ).ToListAsync();
        }

        public async Task<IEnumerable<Inventory>> GetProductInventory(long productId)
        {
            return await _Context.Inventory.Include(x => x.BranchOffice).Include(x => x.Product).Include(x => x.Unit).AsNoTracking().Where(x=>x.Active==true && x.ProductId==productId).ToListAsync();
        }

        public async Task<IEnumerable<Inventory>> GetWarehouseInventory(long warehouseId)
        {
            return await _Context.Inventory.Include(x => x.BranchOffice).Include(x => x.Product).Include(x => x.Unit).AsNoTracking().Where(x => x.Active == true && x.WarehouseId == warehouseId).ToListAsync();
        }

        public async Task<IEnumerable<Inventory>> GetWarehouseInventoryByProduct(long warehouseId, long productId)
        {
            return await _Context.Inventory.Include(x => x.BranchOffice).Include(x => x.Product).Include(x => x.Unit).AsNoTracking()
                .Where(x => x.Active == true && x.ProductId == productId && x.WarehouseId==warehouseId).ToListAsync();
        }
    }
}
