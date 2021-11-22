using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Repository;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Api.Controllers
{


    public class ViewsController : Controller
    {
        readonly IDataRepositoryFactory dataRepository;
        IHttpContextAccessor httpContextAccessor;
        IMemoryCache memoryCache;
        List<LanguageKey> languageKeys;

        public ViewsController(IDataRepositoryFactory dataRepositoryFactory, IHttpContextAccessor context, IMemoryCache _cache) : base()
        {
            this.dataRepository = dataRepositoryFactory;
            this.httpContextAccessor = context;
            this.memoryCache = _cache;
            languageKeys = memoryCache.Get<List<LanguageKey>>("languageKeysMem");
            if (languageKeys == null)
            {
                this.languageKeys = dataRepository.GetDataRepositories<LanguageKey>().GetAll(x => x, y => y.Active == true).Data.ToList();
                memoryCache.Set("languageKeysMem", languageKeys);
            }


        }
       public async Task<IActionResult> Index()
        {
            return View();
        }
        public ActionResult InvoicePrint(long id, string language = "es")
        {
            this.httpContextAccessor.HttpContext.Request.Headers.AddAsync("languageid", language);

            var invoiceRepo = dataRepository.GetDataRepositories<Invoice>();
            var invoice = invoiceRepo.Get(x => x.Include(i => i.Patient).Include(i => i.Seller)
            .Include(i => i.Currency).Include(i => i.InvoiceDetails).ThenInclude(d => d.Product).Include(i=>i.InvoiceDetails).ThenInclude(x=>x.Unit), y => y.Active == true && y.Id == id)?? new Invoice();
            var selectedLanguageKeys = languageKeys.Where(x => x.LanguageCode.ToLower() == language.ToLower()).ToList();
            invoice.InvoiceDetails = invoice.InvoiceDetails.Where(x => x.Active == true).ToList();
            ViewBag.LanguageKeys = selectedLanguageKeys;
            ViewBag.Invoice = invoice;
            ViewBag.CurrentLanguage = language;
            return View();
        }

        public ActionResult AppointmentPrint(long id, string language = "es")
        {
            this.httpContextAccessor.HttpContext.Request.Headers.AddAsync("languageid", language);

            var appointmentRepo = dataRepository.GetDataRepositories<Appointment>();
            var appointment = appointmentRepo.Get(x => 
            x.Include(t => t.Patient).Include(t => t.Insurance).Include(t => t.InsurancePlan).Include(t => t.Hospital)
           .Include(t=>t.Currency)
           .Include(t=>t.Details).ThenInclude(d=>d.Doctor)
           .Include(t => t.Details).ThenInclude(d => d.Doctor)
           .Include(t => t.Details).ThenInclude(d => d.Product)
           .Include(t => t.Details).ThenInclude(d => d.MedicalSpeciality)
            , y => y.Active == true && y.Id == id)??new Appointment();
            var selectedLanguageKeys = languageKeys.Where(x => x.LanguageCode.ToLower() == language.ToLower()).ToList();
          
            ViewBag.LanguageKeys = selectedLanguageKeys;
            ViewBag.Appointment = appointment;
            ViewBag.CurrentLanguage = language;
            return View();
        }

        public ActionResult CheckupMedicationsPrint(long id, string language = "es")
        {
            this.httpContextAccessor.HttpContext.Request.Headers.AddAsync("languageid", language);

            var checkupRepo = dataRepository.GetDataRepositories<PatientCheckup>();
            var checkup = checkupRepo.Get(x => x.Include(t=>t.Doctor).ThenInclude(t=>t.MedicalSpeciality)
            .Include(t => t.Doctor).ThenInclude(t => t.BranchOffice)
            .Include(t=>t.Patient).Include(t=>t.Insurance).Include(t=>t.Insurance).Include(t=>t.Appointment).ThenInclude(x=>x.Hospital)
            .Include(t => t.CheckupPrescriptions).ThenInclude(r => r.MedicalSpeciality)
            .Include(t => t.CheckupPrescriptions).ThenInclude(r => r.Product)
            , y => y.Active == true && y.Id == id)?? new PatientCheckup();
            checkup.CheckupPrescriptions = checkup.CheckupPrescriptions == null ? new List<CheckupPrescription>() : checkup.CheckupPrescriptions.Where(x => x.Active == true && x.Type=='M').ToList();
            var selectedLanguageKeys = languageKeys.Where(x => x.LanguageCode.ToLower() == language.ToLower()).ToList();
            checkup.Appointment = checkup.Appointment != null ? checkup.Appointment : new Appointment() 
            {
            Active=true,
            Hospital=checkup.Doctor.BranchOffice,
            Currency=checkup.Patient.Currency,
            CurrencyId=checkup.Patient.CurrencyId,
            Date=checkup.Date,
            AppointmentType = AppointmentTypes.Consultation.ToString(),
            State = (char)AppointmentStates.InProgress,
            HospitalId=checkup.Doctor.BranchOfficeId.Value,
            PatientId=checkup.PatientId,
            InsuranceId=checkup.InsuranceId,
            InsurancePlanId=checkup.InsurancePlanId,
            
            };
            ViewBag.LanguageKeys = selectedLanguageKeys;
            ViewBag.Checkup = checkup;
            ViewBag.CurrentLanguage = language;
            return View();
        }

        public ActionResult CheckupSpecializedImagesPrint(long id, string language = "es")
        {
            this.httpContextAccessor.HttpContext.Request.Headers.AddAsync("languageid", language);

            var checkupRepo = dataRepository.GetDataRepositories<PatientCheckup>();
            var checkup = checkupRepo.Get(x => x.Include(t => t.Doctor).ThenInclude(t => t.MedicalSpeciality)
             .Include(t => t.Doctor).ThenInclude(t => t.BranchOffice)
            .Include(t => t.Patient).Include(t => t.Insurance).Include(t => t.Insurance).Include(t => t.Appointment).ThenInclude(x => x.Hospital)
            .Include(t => t.CheckupPrescriptions).ThenInclude(r => r.MedicalSpeciality)
            .Include(t => t.CheckupPrescriptions).ThenInclude(r => r.Product)
            , y => y.Active == true && y.Id == id)?? new PatientCheckup();
            checkup.CheckupPrescriptions = checkup.CheckupPrescriptions == null ? new List<CheckupPrescription>() : checkup.CheckupPrescriptions.Where(x => x.Active == true && x.Type == 'E').ToList();
            var selectedLanguageKeys = languageKeys.Where(x => x.LanguageCode.ToLower() == language.ToLower()).ToList();
            checkup.Appointment = checkup.Appointment != null ? checkup.Appointment : new Appointment()
            {
                Active = true,
                Hospital = checkup.Doctor.BranchOffice,
                Currency = checkup.Patient.Currency,
                CurrencyId = checkup.Patient.CurrencyId,
                Date = checkup.Date,
                AppointmentType = AppointmentTypes.Consultation.ToString(),
                State = (char)AppointmentStates.InProgress,
                HospitalId = checkup.Doctor.BranchOfficeId.Value,
                PatientId = checkup.PatientId,
                InsuranceId = checkup.InsuranceId,
                InsurancePlanId = checkup.InsurancePlanId,

            };
            ViewBag.LanguageKeys = selectedLanguageKeys;
            ViewBag.Checkup = checkup;
            ViewBag.CurrentLanguage = language;
            return View();
        }

        public ActionResult CheckupConsultationsPrint(long id, string language = "es")
        {
            this.httpContextAccessor.HttpContext.Request.Headers.AddAsync("languageid", language);

            var checkupRepo = dataRepository.GetDataRepositories<PatientCheckup>();
            var checkup = checkupRepo.Get(x => x.Include(t => t.Doctor).ThenInclude(t => t.MedicalSpeciality)
             .Include(t => t.Doctor).ThenInclude(t => t.BranchOffice)
            .Include(t => t.Patient).Include(t => t.Insurance).Include(t => t.Insurance).Include(t => t.Appointment).ThenInclude(x => x.Hospital)
            .Include(t => t.CheckupPrescriptions).ThenInclude(r => r.MedicalSpeciality)
            .Include(t => t.CheckupPrescriptions).ThenInclude(r => r.Product)
            , y => y.Active == true && y.Id == id)?? new PatientCheckup();
            checkup.CheckupPrescriptions = checkup.CheckupPrescriptions == null ? new List<CheckupPrescription>() : checkup.CheckupPrescriptions.Where(x => x.Active == true && x.Type == 'C').ToList();
            var selectedLanguageKeys = languageKeys.Where(x => x.LanguageCode.ToLower() == language.ToLower()).ToList();
            checkup.Appointment = checkup.Appointment != null ? checkup.Appointment : new Appointment()
            {
                Active = true,
                Hospital = checkup.Doctor.BranchOffice,
                Currency = checkup.Patient.Currency,
                CurrencyId = checkup.Patient.CurrencyId,
                Date = checkup.Date,
                AppointmentType = AppointmentTypes.Consultation.ToString(),
                State = (char)AppointmentStates.InProgress,
                HospitalId = checkup.Doctor.BranchOfficeId.Value,
                PatientId = checkup.PatientId,
                InsuranceId = checkup.InsuranceId,
                InsurancePlanId = checkup.InsurancePlanId,

            };
            ViewBag.LanguageKeys = selectedLanguageKeys;
            ViewBag.Checkup = checkup;
            ViewBag.CurrentLanguage = language;
            return View();
        }

        public ActionResult CheckupLabTestsPrint(long id, string language = "es")
        {
            this.httpContextAccessor.HttpContext.Request.Headers.AddAsync("languageid", language);

            var checkupRepo = dataRepository.GetDataRepositories<PatientCheckup>();
            var checkup = checkupRepo.Get(x => x.Include(t => t.Doctor).ThenInclude(t => t.MedicalSpeciality)
             .Include(t => t.Doctor).ThenInclude(t => t.BranchOffice)
            .Include(t => t.Patient).Include(t => t.Insurance).Include(t => t.Insurance).Include(t => t.Appointment).ThenInclude(x => x.Hospital)
            .Include(t => t.CheckupPrescriptions).ThenInclude(r => r.MedicalSpeciality)
            .Include(t => t.CheckupPrescriptions).ThenInclude(r => r.Product)
            , y => y.Active == true && y.Id == id)?? new PatientCheckup();
            checkup.CheckupPrescriptions = checkup.CheckupPrescriptions == null ? new List<CheckupPrescription>() : checkup.CheckupPrescriptions.Where(x => x.Active == true && x.Type == 'L').ToList();
            var selectedLanguageKeys = languageKeys.Where(x => x.LanguageCode.ToLower() == language.ToLower()).ToList();
            checkup.Appointment = checkup.Appointment != null ? checkup.Appointment : new Appointment()
            {
                Active = true,
                Hospital = checkup.Doctor.BranchOffice,
                Currency = checkup.Patient.Currency,
                CurrencyId = checkup.Patient.CurrencyId,
                Date = checkup.Date,
                AppointmentType = AppointmentTypes.Consultation.ToString(),
                State = (char)AppointmentStates.InProgress,
                HospitalId = checkup.Doctor.BranchOfficeId.Value,
                PatientId = checkup.PatientId,
                InsuranceId = checkup.InsuranceId,
                InsurancePlanId = checkup.InsurancePlanId,

            };
            ViewBag.LanguageKeys = selectedLanguageKeys;
            ViewBag.Checkup = checkup;
            ViewBag.CurrentLanguage = language;
            return View();
        }

        public ActionResult ExpensePrint(long id, string language = "es")
        {
            this.httpContextAccessor.HttpContext.Request.Headers.AddAsync("languageid", language);

            var invoiceRepo = dataRepository.GetDataRepositories<Expense>();
            var invoice = invoiceRepo.Get(x => x.Include(i => i.Supplier).Include(i => i.Currency), y => y.Active == true && y.Id == id)?? new Expense();
            var selectedLanguageKeys = languageKeys.Where(x => x.LanguageCode.ToLower() == language.ToLower()).ToList();
            ViewBag.LanguageKeys = selectedLanguageKeys;
            ViewBag.Expense = invoice;
            ViewBag.CurrentLanguage = language;
            return View();
        }

        public ActionResult InvoicePayment(string sequence, string language = "es")
        {
            this.httpContextAccessor.HttpContext.Request.Headers.AddAsync("languageid", language);

            var paymentsRepo = dataRepository.GetDataRepositories<CustomerPayment>();
            var payments = paymentsRepo.GetAll(x => x.Include(p => p.Customer).Include(p => p.Currency).Include(p => p.Seller).Include(p => p.Invoice), y => y.Active == true && y.Sequence.ToLower() == sequence.ToLower() && y.State == (char)BillingStates.Paid).Data.ToList();
            var selectedLanguageKeys = languageKeys.Where(x => x.LanguageCode.ToLower() == language.ToLower()).ToList();
            ViewBag.LanguageKeys = selectedLanguageKeys;
            ViewBag.Payments = payments;
            ViewBag.CurrentLanguage = language;
            return View();
        }

        public ActionResult ExpensePayment(long id, string language = "es")
        {
            this.httpContextAccessor.HttpContext.Request.Headers.AddAsync("languageid", language);

            var invoiceRepo = dataRepository.GetDataRepositories<Expense>();
            var invoice = invoiceRepo.Get(x => x.Include(i => i.Supplier).Include(i => i.Currency)
            .Include(i => i.Payments), y => y.Active == true && y.Id == id);
            invoice.Payments = invoice.Payments.Where(y => y.Active == true).ToList();
            var selectedLanguageKeys = languageKeys.Where(x => x.LanguageCode.ToLower() == language.ToLower()).ToList();
            ViewBag.LanguageKeys = selectedLanguageKeys;
            ViewBag.Expense = invoice;
            ViewBag.CurrentLanguage = language;
            return View();
        }

     
    }
}
