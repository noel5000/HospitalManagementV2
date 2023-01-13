

using Microsoft.Extensions.Options;

namespace PointOfSalesV2.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        protected readonly IOptions<AppSettings> _appSettings;
        public UserRepository(MainDataContext context, IOptions<AppSettings> appSettings) : base(context)
        {
            this._appSettings = appSettings;
        }

        public async Task<User> Login(Login login,string tokenKey)
        {
            var user = await _Context.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Active == true && u.Email == login.Email && u.Password == MD5.Encrypt(login.Password, tokenKey));
            if (user != null) 
            {
               user.Permissions =
                      await  (
                        from ur in _Context.UserRoles
                        join rs in _Context.RoleSectionOperations on ur.RoleId equals rs.RoleId
                        join so in _Context.SectionOperations.Include(x=>x.Section).Include(x=>x.Operation) on rs.SectionOperationId equals so.Id
                        
                        where ur.UserId == user.UserId && ur.Active == true
                        select new UserOperation()
                        {
                           Controllers=so.Section.Controllers,
                           OperationId=so.OperationId,
                           OperationName=so.Operation.Name,
                           SectionId=so.SectionId,
                           SectionName=so.Section.Name
                        }
                        ).ToListAsync();

            }
         await   _Context.DisposeAsync();
            return user;
        }

      

        public override async Task< Result<User>> AddAsync(User entity)
        {
            entity.Password = MD5.Encrypt(entity.Password, _appSettings.Value.TokenKey);
            if (_Context.Users.Any(x => x.Email.ToLower() == entity.Email.ToLower()))
                return new Result<User>(-1, -1, "alreadyExists_error");

            return await base.AddAsync(entity);
        }

        public override async Task<Result<User>> UpdateAsync(User entity, bool fromDb = true)
        {
            try
            {
                var dbEntity =await _Context.Users.FindAsync(entity.UserId);
                _Context.Entry<User>(dbEntity).State = EntityState.Detached;
                if (!string.IsNullOrEmpty(entity.Password)) 
                {
                    entity.Password = MD5.Encrypt(entity.Password, _appSettings.Value.TokenKey);
                }
                var translation = dbEntity as IEntityTranslate;
                if (translation != null)
                {
                    languages = await _Context.Set<Language>().AsNoTracking().Where(x => x.Active == true).ToListAsync();
                    entity.TranslationData = TranslateUtility.SaveTranslation(entity, translation.TranslationData,languages);

                }
                _Context.Users.Attach(entity);
                _Context.Entry<User>(entity).State = EntityState.Modified;

              await  _Context.SaveChangesAsync();

                return new Result<User>(entity.Id, 0, "OK", new List<User>() { entity });
            }

            catch (Exception ex)
            {
                return new Result<User>(-1, -1, ex.Message, null, ex);
            }

        }
    }
}
