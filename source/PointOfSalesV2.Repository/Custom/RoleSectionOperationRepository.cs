

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
                    from rso in _Context.RoleSectionOperations.Include(x => x.Role)
                    join so in _Context.SectionOperations.Include(x => x.Section).Include(x => x.Operation) on rso.SectionOperationId equals so.Id
                    where rso.Active == true
                    select new RoleSectionOperation()
                    {
                        SectionOperation = so,
                        Active = rso.Active,
                        CreatedBy = rso.CreatedBy,
                        CreatedByName = rso.CreatedByName,
                        CreatedDate = rso.CreatedDate,
                        Id = rso.Id,
                        ModifiedBy = rso.ModifiedBy,
                        ModifiedByName = rso.ModifiedByName,
                        ModifiedDate = rso.ModifiedDate,
                        Role = rso.Role,
                        RoleId = rso.RoleId,
                        SectionOperationId = rso.SectionOperationId,
                        TranslationData = rso.TranslationData,
                        Section = so.Section,
                        Operation = so.Operation
                    }
                    ).AsQueryable();
            });
        }
    }
}
