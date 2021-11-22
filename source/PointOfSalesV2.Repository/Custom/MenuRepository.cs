using Microsoft.EntityFrameworkCore;
using NPOI.HSSF.Record;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Repository.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public class MenuRepository : Repository<Menu>, IMenuRepository
    {
        readonly ISequenceManagerRepository _sequenceRepo;
        readonly IDataRepositoryFactory _repoFactory;
        public MenuRepository(MainDataContext context, ISequenceManagerRepository sequenceManagerRepository, IDataRepositoryFactory dataRepositoryFactory) : base(context)
        {
            this._repoFactory = dataRepositoryFactory;
            this._sequenceRepo = sequenceManagerRepository;
        }
        public override async  Task<Result<Menu>> AddAsync(Menu entity)
        {
            var result = new Result<Menu>(-1, -1, "error_msg");
            using (var trans = await _Context.Database.BeginTransactionAsync())
            {
                try
                {
                    if ((int)entity.DayOfWeek > 6 || entity.WeekNumber > 4 || (entity.MenuDetails == null || entity.MenuDetails.Count == 0))
                    {
                        trans.Rollback();
                        result = new Result<Menu>(-1, -1, "invalidMenu_msg");
                        return result;
                    }
                    var existingMenu = await _Context.Menus.Include(x => x.MenuDetails).AsNoTracking().FirstOrDefaultAsync(x => x.Active == true && x.DayOfWeek == entity.DayOfWeek && x.WeekNumber == entity.WeekNumber);
                    if (existingMenu != null)
                    {
                        _Context.MenuDetails.RemoveRange(existingMenu.MenuDetails);
                       await _Context.SaveChangesAsync();
                        entity.MenuDetails.ForEach(d =>
                        {
                            d.MenuId = existingMenu.Id;
                            d.Product = null;
                            d.Unit = null;
                            d.Menu = null;
                            d.Id = 0;

                        });
                        _Context.MenuDetails.AddRange(entity.MenuDetails);
                     await    _Context.SaveChangesAsync();
                    }
                    else
                    {
                        entity.Sequence = await _sequenceRepo.CreateSequence(Common.Enums.SequenceTypes.Menus);
                        entity.MenuDetails.ForEach(d =>
                        {
                            d.Product = null;
                            d.Unit = null;
                            d.Menu = null;
                        });

                        _Context.Menus.Add(entity);
                    await    _Context.SaveChangesAsync();
                    }
                    result = new Result<Menu>(entity.Id, 0, "ok_msg");
                   await trans.CommitAsync();
                }
                catch (Exception ex)
                {
                    result = new Result<Menu>(-1, -1, "error_msg", null, new Exception(ex.Message));
                   await trans.RollbackAsync();
                }
            }

            return result;
        }

        public override async Task< Result<Menu>> UpdateAsync(Menu entity, bool fromDb = true)
        {
            var result = new Result<Menu>(-1, -1, "error_msg");
            using (var trans = await _Context.Database.BeginTransactionAsync())
            {
                try
                {
                    if ((int)entity.DayOfWeek > 6 || entity.WeekNumber > 4 || (entity.MenuDetails == null || entity.MenuDetails.Count == 0))
                    {
                        trans.Rollback();
                        result = new Result<Menu>(-1, -1, "invalidMenu_msg");
                        return result;
                    }
                    var existingMenu = await _Context.Menus.AsNoTracking().FirstOrDefaultAsync(x => x.Active == true && x.Id == entity.Id);
                    if (existingMenu != null)
                    {
                        var existinDetails = await _Context.MenuDetails.AsNoTracking().Where(x => x.Active == true && x.MenuId == existingMenu.Id).ToListAsync();
                        existingMenu.DayOfWeek = entity.DayOfWeek;
                        existingMenu.WeekNumber = existingMenu.WeekNumber;
                        entity.MenuDetails.ForEach(d =>
                        {
                            d.MenuId = existingMenu.Id;
                            d.Product = null;
                            d.Unit = null;
                            d.Menu = null;
                        });
                        _Context.Menus.Update(existingMenu);
                        _Context.SaveChanges();
                        existinDetails.ForEach(ed =>
                        {
                            int index = entity.MenuDetails.FindIndex(x => x.Id == ed.Id);
                            if (index > 0)
                            {
                                ed = entity.MenuDetails[index];
                                _Context.MenuDetails.Update(ed);
                                _Context.SaveChanges();
                            }
                            else
                            {
                                _Context.MenuDetails.Remove(ed);
                                _Context.SaveChanges();
                            }
                        });
                        _Context.MenuDetails.AddRange(entity.MenuDetails.Where(x => x.Id == 0));
                    await    _Context.SaveChangesAsync();
                    }
                    else
                    {
                   await     trans.RollbackAsync();
                        result = new Result<Menu>(-1, -1, "invalidMenu_msg");
                        return result;
                    }
                    result = new Result<Menu>(entity.Id, 0, "ok_msg");
                 await   trans.CommitAsync();
                }
                catch (Exception ex)
                {
                    result = new Result<Menu>(-1, -1, "error_msg", null, new Exception(ex.Message));
                await    trans.RollbackAsync();
                }
            }

            return result;
        }

        public async Task< Result<object>> DeleteMenuEntry(byte weekNo, DayOfWeek dayOfWeek)
        {
            var result = new Result<object>(-1, -1, "error_msg");
            using (var trans = await _Context.Database.BeginTransactionAsync())
            {
                try
                {
                    var entity = await _Context.Menus.AsNoTracking().FirstOrDefaultAsync(m => m.Active == true
                        && m.WeekNumber == weekNo && m.DayOfWeek == dayOfWeek);
                    if (entity == null)
                    {
                       await trans.RollbackAsync();
                        return new Result<object>(-1, -1, "menuNotExisting_msg");
                    }
                    if ((int)entity.DayOfWeek > 6 || entity.WeekNumber > 4)
                    {
                      await  trans.RollbackAsync();
                        result = new Result<object>(-1, -1, "invalidMenu_msg");
                        return result;
                    }
                    var existingMenu = await _Context.MenuDetails.AsNoTracking().Where(x => x.Active == true && x.MenuId == entity.Id).ToListAsync();
                    if (existingMenu != null)
                    {
                        _Context.MenuDetails.RemoveRange(existingMenu);
                      await  _Context.SaveChangesAsync();


                    }
                    entity.Active = false;
                    _Context.Menus.Update(entity);
                 await   _Context.SaveChangesAsync();
                    result = new Result<object>(entity.Id, 0, "ok_msg");
                 await   trans.CommitAsync();
                }
                catch (Exception ex)
                {
                    result = new Result<object>(-1, -1, "error_msg", null, new Exception(ex.Message));
                  await  trans.RollbackAsync();
                }
            }

            return result;
        }

        public async Task<List<InvoiceLeadProjection>> MonthProjection(DateTime currentDate, long branchOfficeId = 0, long warehouseId = 0)
        {

            var startDate = new DateTime(currentDate.Year, currentDate.Month, 1);
            var endDate = startDate.AddMonths(1);
            List<InvoiceLeadProjection> result = new List<InvoiceLeadProjection>();

            var monthLeads = await _Context.InvoicesLeads.AsNoTracking().Where(x => x.Active == true &&
            x.Date >= startDate && x.Date <= endDate && x.State != (char)Enums.BillingStates.Nulled).ToListAsync();

            var schools = await _Context.Schools.AsNoTracking().Where(x => x.Active == true).ToListAsync();
            var menus =await _Context.Menus.AsNoTracking().Where(x => x.Active == true).ToListAsync();

            var projectedSequences = await _Context.SequencesControl.AsNoTracking().FirstOrDefaultAsync(x => x.Active == true
            && x.Code == (byte)Enums.SequenceTypes.Leads);

            while (startDate <= endDate)
            {
                List<Inventory> tempInventoryToUpdate = new List<Inventory>();
                var weekOfMonth = DateUtility.GetWeekOfMonth(startDate);
                DayOfWeek dayOfWeek = startDate.DayOfWeek;
                if ((int)dayOfWeek > 0 && (int)dayOfWeek < 6)
                {
                    var selectedMenu = menus.FirstOrDefault(x => x.DayOfWeek == dayOfWeek && x.WeekNumber == (weekOfMonth - 1));
                    if (selectedMenu != null)
                    {
                        var existence = branchOfficeId <= 0 ? new List<Inventory>() : _Context.Inventory.AsNoTracking().Where(x => x.Active == true && x.BranchOfficeId == branchOfficeId && (warehouseId <= 0 ? x.WarehouseId > 0 : x.WarehouseId == warehouseId)).ToList();
                        tempInventoryToUpdate.ForEach(t =>
                        {
                            int index = existence.FindIndex(x => x.Id == t.Id);
                            if (index >= 0)
                                existence[index] = t;
                        });
                        foreach (var school in schools)
                        {
                            bool notExpiredLead = startDate >= new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                            var enoughtExistence = notExpiredLead ? InventoryHelper.VerifyExistence(_Context.MenuDetails.AsNoTracking()
                                .Include(d => d.Product)
                                .Where(x => x.Active == true && x.MenuId == selectedMenu.Id)
                                .ToList<IDetailEntity>(), _repoFactory, existence) : true;
                            var schoolLead = monthLeads.FirstOrDefault(x => x.Date.Day == startDate.Day && x.SchoolId == school.Id);
                            string sequence = String.Format("{0}{1:00000}",
                                ((Enums.SequenceTypeCode)(short)projectedSequences.Code).ToString(),
                                (projectedSequences.NumericControl + 1));

                            projectedSequences.NumericControl += 1;
                            result.Add(new InvoiceLeadProjection()
                            {
                                Id = schoolLead == null ? 0 : schoolLead.Id,
                                DayOfWeek = dayOfWeek,
                                WeekOfMonth = (byte)weekOfMonth,
                                MenuId = selectedMenu.Id,
                                SchoolId = school.Id,
                                SchoolName = $"{school.Code} {school.Name}",
                                LeadSequence =string.IsNullOrEmpty(string.IsNullOrEmpty(schoolLead?.InvoiceNumber)?schoolLead?.DocumentNumber:schoolLead?.InvoiceNumber)? sequence:
                                (string.IsNullOrEmpty(schoolLead?.InvoiceNumber) ? schoolLead?.DocumentNumber : schoolLead?.InvoiceNumber),
                                Date = startDate,
                                EnoughExistence=enoughtExistence,
                                State = schoolLead == null ? (notExpiredLead ?
                            (enoughtExistence ? (char)Enums.BillingStates.Projected : (char)Enums.BillingStates.NotEnoughInventory)
                            : (char)Enums.BillingStates.Expired) : schoolLead.State
                            });
                            existence.ForEach(e =>
                            {
                                int index = tempInventoryToUpdate.FindIndex(x => x.Id == e.Id);
                                if (index >= 0)
                                    tempInventoryToUpdate[index] = e;
                                else
                                    tempInventoryToUpdate.Add(e);
                            });
                        }
                    }

                }
                startDate = startDate.AddDays(1);
            }
            return result;
        }

        public override async Task< Result<Menu>> GetAsync(long id)
        {
            var entity = await _Context.Menus.FindAsync(id);
            _Context.Entry<Menu>(entity).State = EntityState.Detached;
            entity.MenuDetails = await _Context.MenuDetails.AsNoTracking()
                .Include(x => x.Product).ThenInclude(x=>x.Taxes).ThenInclude(x=>x.Tax)
                .Include(x=>x.Product).ThenInclude(x => x.ProductUnits).ThenInclude(x=>x.Unit)
                .Include(x => x.Unit).Where(x => x.Active == true && x.MenuId == id).ToListAsync();

            return new Result<Menu>(id, 0, "ok_msg", new List<Menu>() { entity });
        }

    }
}
