﻿using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text; using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public interface ICashRegisterOpeningRepository : IBase<CashRegisterOpening>
    {
        Task<Result<CashRegisterOpening>> Closure(CashRegisterOpening cashRegisterOpening);
    }
}
