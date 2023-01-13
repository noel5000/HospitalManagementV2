

namespace PointOfSalesV2.Repository
{
    public class RoleSectionOperationRepository : Repository<RoleSectionOperation>, IRoleSectionOperationRepository 
    { 
        public RoleSectionOperationRepository(MainDataContext context) : base(context)
        {
        }

        public async Task< IQueryable<RoleSectionOperation>> GetWithAllChildren()
        {
            return await Task.Factory.StartNew<IQueryable<RoleSectionOperation>>(() =>{
                return (
                    from rso in _Context.RoleSectionOperations.Include(x => x.Role).Include(x=>x.Operation)
                    where rso.Active == true
                    select new RoleSectionOperation()
                    {
                        Active = rso.Active,
                        CreatedBy = rso.CreatedBy,
                        CreatedByName = rso.CreatedByName,
                        CreatedDate = rso.CreatedDate,
                        Id = rso.Id,
                        ModifiedBy = rso.ModifiedBy,
                        ModifiedByName = rso.ModifiedByName,
                        ModifiedDate = rso.ModifiedDate,
                        Role = rso.Role,
                        Operation = rso.Operation,
                        OperationId = rso.OperationId,
                        Section=rso.Section,
                        RoleId = rso.RoleId,
                        TranslationData = rso.TranslationData,
                    }
                    ).AsQueryable();
            });
        }
    }
}
