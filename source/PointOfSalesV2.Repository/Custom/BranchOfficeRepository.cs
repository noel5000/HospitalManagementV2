using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text; using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public class BranchOfficeRepository : Repository<BranchOffice>, IBranchOfficeRepository
    {
        
        public BranchOfficeRepository(MainDataContext context) : base(context)
        {
        }

      
    }
}
