﻿using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text; using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public interface IWarehouseMovementRepository : IBase<WarehouseMovement>
    {
        Task<IEnumerable<WarehouseMovement>> GetMovementsByProduct(long? productId, long? warehouseId, DateTime? initialDate, DateTime? endDate);
        Task<IEnumerable<WarehouseMovement>> GetProductHistory(long? productId);
    }
}
