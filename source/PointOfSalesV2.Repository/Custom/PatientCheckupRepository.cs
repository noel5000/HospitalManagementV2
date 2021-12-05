
namespace PointOfSalesV2.Repository
{
    public class PatientCheckupRepository : Repository<PatientCheckup>, IPatientCheckupRepository
    {
       readonly IDataRepositoryFactory factory;
        public PatientCheckupRepository(MainDataContext context, IDataRepositoryFactory dataRepositoryFactory) : base(context)
        {
            this.factory = dataRepositoryFactory;
        }

        public override async Task< Result<PatientCheckup>> GetAsync(long id)
        {
            var entity = await _Context.PatientCheckups.AsNoTracking().Include(x=>x.Doctor)
                .Include(x=>x.Insurance).Include(x=>x.InsurancePlan).Include(x=>x.Patient).Include(x=>x.CheckupPrescriptions).ThenInclude(x=>x.MedicalSpeciality)
                .Include(x=>x.CheckupPrescriptions).ThenInclude(d=>d.Product).FirstOrDefaultAsync(x=>x.Active==true && x.Id==id);
            if (entity == null)
                return new Result<PatientCheckup>(-1, -1, "notFound_msg");
            entity.CheckupPrescriptions = entity.CheckupPrescriptions.Where(s => s.Active == true).ToList();

            return new Result<PatientCheckup>(entity.Id, 0, "ok_msg", new List<PatientCheckup>() { entity });
        }

        public override async Task< Result<PatientCheckup>> AddAsync(PatientCheckup entity)
        {
            Result<PatientCheckup> result = new Result<PatientCheckup>(-1, -1, "error_msg");
            using (var transaction = await _Context.Database.BeginTransactionAsync()) 
            {
                
                try
                {
                    var appointment = entity.AppointmentId.HasValue && entity.AppointmentId>0?await _Context.Appointments.AsNoTracking().Include(x => x.Details).FirstOrDefaultAsync(x => x.Id == entity.AppointmentId):null;
                    if (appointment == null) 
                    {
                        appointment = new Appointment()
                        {
                            State= (char)AppointmentStates.InProgress,
                            Date=DateTime.Now,
                            InsuranceId=entity.InsuranceId,
                            InsurancePlanId=entity.InsurancePlanId,
                            PatientId=entity.PatientId,
                            AppointmentType= AppointmentTypes.Consultation.ToString(),
                            Details=new List<AppointmentDetail>() { new AppointmentDetail() { 
                            Active=true,
                            DoctorId=entity.DoctorId
                            } },
                            CurrencyId=entity.Patient.CurrencyId
                        };
                    }
                    appointment.Details = appointment.Details.Where(x => x.Active == true).ToList();
                    entity.Appointment = appointment;
                    var prescriptions = await SetEntity(entity);
                    entity.Appointment = null;
                    var consultationDetail = appointment.Details.FirstOrDefault(x => x.AppointmentType == AppointmentTypes.Consultation);
                    if (appointment == null || appointment.AppointmentState== AppointmentStates.Nulled || consultationDetail==null) 
                    {
                     await   transaction.RollbackAsync();
                        return new Result<PatientCheckup>(-1, -1, "appointmentNotValid_msg");
                    }
                    entity.Date = appointment.Date;
                    entity.InsuranceId = appointment.InsuranceId;
                    entity.InsurancePlanId = appointment.InsurancePlanId;
                    entity.DoctorId = consultationDetail.DoctorId.HasValue? consultationDetail.DoctorId.Value:entity.DoctorId;
                    entity.PatientId = appointment.PatientId;
                    result = await base.AddAsync(entity);
                    if (result.Status < 0) 
                    {
                        
                      await  transaction.RollbackAsync();
                        return result;
                    }
                  


                    appointment.State = (appointment.AppointmentState == AppointmentStates.Scheduled || appointment.AppointmentState == AppointmentStates.Expired) ? (char)AppointmentStates.InProgress : appointment.State;
                    if (appointment.Id > 0) 
                    {
                        _Context.Appointments.Update(appointment);
                     await   _Context.SaveChangesAsync();
                    }
                   
                    result = SavePrescriptions(prescriptions, result);
                    if (result.Status < 0)
                    {
                     await   transaction.RollbackAsync();
                        return result;
                    }
               await     transaction.CommitAsync();
                    
                }
                catch (Exception ex) 
                {
                  await  transaction.RollbackAsync();
                    result= new Result<PatientCheckup>(-1, -1, $"error_msg: | {ex.Message}", null, ex);
                }
            }

            return result;

        }

        public override async Task< Result<PatientCheckup>> UpdateAsync(PatientCheckup entity, bool getFromDb = true)
        {
            Result<PatientCheckup> result = new Result<PatientCheckup>(-1, -1, "error_msg");
            using (var transaction = await _Context.Database.BeginTransactionAsync())
            {
                try
                {
                    var appointment =  entity.AppointmentId.HasValue && entity.AppointmentId > 0 ? await _Context.Appointments.AsNoTracking().Include(x => x.Details).FirstOrDefaultAsync(x => x.Id == entity.AppointmentId) : null;
                    if (appointment == null)
                    {
                        appointment = new Appointment()
                        {
                            State = (char)AppointmentStates.InProgress,
                            Date = DateTime.Now,
                            InsuranceId = entity.InsuranceId,
                            InsurancePlanId = entity.InsurancePlanId,
                            PatientId = entity.PatientId,
                            AppointmentType = AppointmentTypes.Consultation.ToString(),
                            Details = new List<AppointmentDetail>() { new AppointmentDetail() {
                            Active=true,
                            DoctorId=entity.DoctorId
                            } },
                            CurrencyId = entity.Patient.CurrencyId
                        };
                    }
                    appointment.Details = appointment.Details.Where(x => x.Active == true).ToList();
                    entity.Appointment = appointment;
                    var prescriptions = await SetEntity(entity);
                    entity.Appointment = null;
                    result = await base.UpdateAsync(entity);
                    if (result.Status < 0)
                    {
                        await transaction.RollbackAsync();
                        return result;
                    }
                    if (appointment.AppointmentState == AppointmentStates.Nulled)
                    {
                        await transaction.RollbackAsync();
                        await  transaction.DisposeAsync();
                        result = new Result<PatientCheckup>(-1, -1, "appointmentNulled_msg");
                        return result;
                    }


                    appointment.State = (appointment.AppointmentState == AppointmentStates.Scheduled || appointment.AppointmentState == AppointmentStates.Expired) ? (char)AppointmentStates.InProgress : appointment.State;
                    if (appointment.Id > 0) 
                    {
                        _Context.Appointments.Update(appointment);
                     await   _Context.SaveChangesAsync();
                    }

                    result = UpdatePrescriptions(prescriptions, result);
                    if (result.Status < 0)
                    {
                      await  transaction.RollbackAsync();
                        return result;
                    }
                  await  transaction.CommitAsync();

                }
                catch (Exception ex)
                {
                  await  transaction.RollbackAsync();
                    result = new Result<PatientCheckup>(-1, -1, $"error_msg: | {ex.Message}", null, ex);
                }
            }

            return result;
        }

        private Result<PatientCheckup> SavePrescriptions(List<CheckupPrescription> prescriptions, Result<PatientCheckup> result) 
        {
            try
            {
                if (result.Status < 0)
                    return result;

                for (int i = 0; i < prescriptions.Count; i++)
                {
                    prescriptions[i].PatientCheckupId = result.Id;
                    
                }
                _Context.CheckupPrescriptions.AddRange(prescriptions);
                _Context.SaveChanges();
            }
            catch (Exception ex) 
            {
                result= new Result<PatientCheckup>(-1, -1, $"error_msg | {ex.Message}", null, ex);
            }
            return result;

        }
        private Result<PatientCheckup> UpdatePrescriptions(List<CheckupPrescription> prescriptions, Result<PatientCheckup> result)
        {
            try
            {
                if (result.Status < 0)
                    return result;
                var oldPrescriptions = _Context.CheckupPrescriptions.AsNoTracking().Where(x => x.Active == true && x.PatientCheckupId == result.Id).ToList();

                for (int i = 0; i < oldPrescriptions.Count; i++)
                {
                    oldPrescriptions[i].PatientCheckupId = result.Id;
                    oldPrescriptions[i].Active = false;

                }

                _Context.CheckupPrescriptions.RemoveRange(oldPrescriptions);
                _Context.SaveChanges();

                for (int i = 0; i < prescriptions.Count; i++)
                {
                    prescriptions[i].PatientCheckupId = result.Id;
                    prescriptions[i].Id = 0;
                    prescriptions[i].Active = true;
                }
                _Context.CheckupPrescriptions.AddRange(prescriptions);
                _Context.SaveChanges();
            }
            catch (Exception ex)
            {
                result = new Result<PatientCheckup>(-1, -1, $"error_msg | {ex.Message}", null, ex);
            }
            return result;

        }

        private async Task<List<CheckupPrescription>> SetEntity(PatientCheckup entity) 
        {
            
           
            var prescriptions = entity.CheckupPrescriptions?? new List<CheckupPrescription>();
            entity.CheckupPrescriptions = null;
            entity.Active = true;

            var newPrescriptionsProducts = prescriptions.Where(x=> x.Product != null && x.Product.Id <= 0 && !string.IsNullOrEmpty(x.Product.Name)).Select(x=>x.Product).ToList();
            var newPrescriptionsMedicalSpecialities = prescriptions.Where(x => x.MedicalSpeciality != null && x.MedicalSpeciality.Id <= 0 && !string.IsNullOrEmpty(x.MedicalSpeciality.Name)).Select(x => x.MedicalSpeciality).ToList();
            var newProductsResult =(await AddNewPrescriptionProducts(newPrescriptionsProducts, entity)).Data?.ToList()??new List<Product>();
            var newMedicalSpecialitiesResult =  AddNewPrescriptionMedicalSpecialities(newPrescriptionsMedicalSpecialities, entity).Data?.ToList() ?? new List<MedicalSpeciality>();
            for (int i = 0; i < prescriptions.Count; i++)
            {
                int index = newProductsResult.FindIndex(x => x.OldId == prescriptions[i].ProductId);
                if (index >= 0)
                    prescriptions[i].ProductId = newProductsResult[index].Id;

                int medicalEIndex = newMedicalSpecialitiesResult.FindIndex(x => x.OldId == prescriptions[i].MedicalSpecialityId);
                if (medicalEIndex >= 0)
                    prescriptions[i].MedicalSpecialityId = newMedicalSpecialitiesResult[medicalEIndex].Id;

                prescriptions[i].Product = null;
                prescriptions[i].MedicalSpeciality = null;
                prescriptions[i].Active = true;
                prescriptions[i].PatientCheckup = null;
                prescriptions[i].Quantity = prescriptions[i].Quantity <= 0 ? 1 : prescriptions[i].Quantity;
            }
            entity.Appointment = null;
            entity.Doctor = null;
            entity.Insurance = null;
            entity.InsurancePlan = null;
            entity.Patient = null;
            return prescriptions;
        }

        private async Task<long> AddNewPrescriptionProduct(Product product, PatientCheckup checkup) 
        {
            product.Description = product.Name;
            product.Price = 1;
            product.Price2 = 0;
            product.Price3 = 0;
            product.Active = true;
            product.Code = "";
            product.Cost = 0;
            product.CurrencyId = checkup.Appointment.CurrencyId;
            product.IsCompositeProduct = false;
           // product.IsService = false;
           // product.MedicalSpecialityId = null;
            product.Taxes = await _Context.Taxes.AsNoTracking().Where(x => x.Active == true && (x.Rate == 0 || x.Rate == 0.18m)).Select(x => new ProductTax()
            {
                Active = true,
                ProductId=0,
                TaxId=x.Id
            }).ToListAsync() ;
            product.ProductUnits = product.IsService?null: _Context.Units.AsNoTracking().Take(1).ToList().Select(x => new UnitProductEquivalence() { 
            Active=true,
            CostPrice=0,
            Equivalence=1,
            IsPrimary=true,
            Order=1,
            ProductId=0,
            SellingPrice=0,
            UnitId=x.Id
            });
            var repo = this.factory.GetCustomDataRepositories<IProductRepository>();
            var result = await repo.AddWithoutTransaction(product);
            if (result.Status < 0)
                throw result.Exception?? new Exception(result.Message);
            return result.Id;
            
        }

        private async Task<Result<Product>> AddNewPrescriptionProducts(List<Product> products, PatientCheckup checkup)
        {
            var taxes = await _Context.Taxes.AsNoTracking().Where(x => x.Active == true && (x.Rate == 0)).Select(x => new ProductTax()
            {
                Active = true,
                ProductId = 0,
                TaxId = x.Id
            }).ToListAsync();
            var productUnit= (await _Context.Units.AsNoTracking().Take(1).ToListAsync()).Select(x => new UnitProductEquivalence()
            {
                Active = true,
                CostPrice = 0,
                Equivalence = 1,
                IsPrimary = true,
                Order = 1,
                ProductId = 0,
                SellingPrice = 0,
                UnitId = x.Id
            }).ToList();
           for(int i=0;i<products.Count();i++)
            {
                products[i].Description = products[i].Name;
                products[i].Price = 1;
                products[i].Price2 = 0;
                products[i].Price3 = 0;
                products[i].Active = true;
                products[i].OldId = products[i].Id;
                products[i].Code = "";
                products[i].Cost = 0;
                products[i].CurrencyId = checkup.Appointment.CurrencyId;
                products[i].IsCompositeProduct = false;
                // product.IsService = false;
                // product.MedicalSpecialityId = null;
                products[i].Taxes = taxes;
                products[i].ProductUnits = products[i].IsService ? null : productUnit;


            }

            var oldIds = products.Select(x => x.OldId).ToList();
            var repo = this.factory.GetCustomDataRepositories<IProductRepository>();
            var result = await repo.AddRangeWithoutTransaction(products,false);
            if (result.Data != null) 
            {
                var data = result.Data.ToList();
                for (int i = 0; i < oldIds.Count; i++)
                {
                    data[i].OldId = oldIds[i];
                }
                result.Data = data;
            }
                
            return result;
        }

        private Result<MedicalSpeciality> AddNewPrescriptionMedicalSpecialities(List<MedicalSpeciality> medicalSpecialities, PatientCheckup checkup)
        {
            languages =languages==null || languages.Count<=0? _Context.Set<Language>().AsNoTracking().Where(x => x.Active == true).ToList():languages;

            for (int i = 0; i < medicalSpecialities.Count(); i++)
            {
               
                medicalSpecialities[i].Active = true;
                medicalSpecialities[i].OldId = medicalSpecialities[i].Id;
                medicalSpecialities[i].Id = 0;
                var translation = medicalSpecialities[i] as IEntityTranslate;
                medicalSpecialities[i].TranslationData = TranslateUtility.SaveTranslation(medicalSpecialities[i], translation.TranslationData, languages);
            }

            var oldIds = medicalSpecialities.Select(x => x.OldId).ToList();
            var repo = this.factory.GetDataRepositories<MedicalSpeciality>();
            repo.AddRange(medicalSpecialities);

            var result = new Result<MedicalSpeciality>(0, 0, "ok_msg", medicalSpecialities);
            if (result.Data != null)
            {
                var data = result.Data.ToList();
                for (int i = 0; i < oldIds.Count; i++)
                {
                    data[i].OldId = oldIds[i];
                }
                result.Data = data;
            }

            return result;
        }

        public async Task<List<PatientCheckup>> GetPatientHistory(long patientId)
        {
            var entities = await _Context.PatientCheckups.AsNoTracking().Include(x => x.Doctor)
                .Include(x=>x.Appointment)
                .Include(x => x.Insurance).Include(x => x.InsurancePlan).Include(x => x.Patient).Where(x => x.Active == true && x.PatientId == patientId).OrderByDescending(x=>x.Date).ToListAsync();
            return entities;
        }
    }
}
