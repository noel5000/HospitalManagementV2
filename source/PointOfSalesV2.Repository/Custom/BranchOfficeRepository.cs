

namespace PointOfSalesV2.Repository
{
    public class BranchOfficeRepository : Repository<BranchOffice>, IBranchOfficeRepository
    {
        
        public BranchOfficeRepository(MainDataContext context) : base(context)
        {
        }

      
    }
}
