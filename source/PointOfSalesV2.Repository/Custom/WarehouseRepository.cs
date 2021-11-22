﻿using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text; using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public class WarehouseRepository : Repository<Warehouse>, IWarehouseRepository
    {
        public WarehouseRepository(MainDataContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Inventory>> GetProductInventory(long productId)
        {
            throw new NotImplementedException();
        }
    }
}
