﻿using PointOfSalesV2.Entities; using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointOfSalesV2.FrontEnd.Models
{
    public class SupplierReturnModel
    {
        public string Reference { get; set; }
        public string Details { get; set; }

        public List<SupplierReturn> Entries { get; set; }
    }
}
