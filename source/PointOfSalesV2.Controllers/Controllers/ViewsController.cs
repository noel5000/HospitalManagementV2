using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Repository;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Controllers
{
    public class ViewsController : Controller
    {
        readonly IDataRepositoryFactory dataRepository;
        IWebHostEnvironment hostingEnvironment;
        IHttpContextAccessor httpContextAccessor;
        IMemoryCache memoryCache;
        Dictionary<string,string> languageKeys;
        
        public ViewsController(IWebHostEnvironment appEnviroment, IDataRepositoryFactory dataRepositoryFactory, IHttpContextAccessor context, IMemoryCache _cache) : base() 
        {
            this.hostingEnvironment = appEnviroment;
            this.dataRepository = dataRepositoryFactory;
            this.httpContextAccessor = context;
            this.memoryCache = _cache;
           
                
           
        }

        Dictionary<string, string> GetDictionary(string language) 
        {
            languageKeys = (memoryCache.Get("languageKeysMem")) as Dictionary<string,string>;
            if (languageKeys == null)
            {
                languageKeys = JsonConvert.DeserializeObject<Dictionary<string,string>>( System.IO.File.ReadAllText(Path.Combine(hostingEnvironment.WebRootPath, $"i18N/{language.ToUpper()}.json")));

                memoryCache.Set("languageKeysMem", languageKeys,DateTimeOffset.Now.AddHours(4));
            }
            return languageKeys;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> InvoicePrint(long id, string language = "es")
        {
            this.httpContextAccessor.HttpContext.Request.Headers.Add("languageid", language);

            var invoiceRepo = dataRepository.GetDataRepositories<Invoice>();
            var invoice = await invoiceRepo.GetAsync(x => 
            x.Include(i => i.Patient).Include(i=>i.BranchOffice)
            .Include(i => i.Insurance).Include(i => i.InsurancePlan)
            .Include(i => i.Seller).Include(i => i.Currency)
            .Include(i => i.InvoiceDetails).ThenInclude(d => d.Product)
            .Include(i => i.InvoiceDetails).ThenInclude(x => x.Unit), y => y.Active == true && y.Id == id) ?? new Invoice();
            var selectedLanguageKeys = this.GetDictionary(language);
            invoice.InvoiceDetails = invoice.InvoiceDetails.Where(x => x.Active == true).ToList();
            ViewBag.LanguageKeys = selectedLanguageKeys;
            ViewBag.Invoice = invoice;
            ViewBag.CurrentLanguage = language;
            return View();
        }

        public async Task<ActionResult> AppointmentPrint(long id, string language = "es")
        {
            this.httpContextAccessor.HttpContext.Request.Headers.Add("languageid", language);

            var appointmentRepo = dataRepository.GetDataRepositories<Appointment>();
            var appointment = await appointmentRepo.GetAsync(x =>
            x.Include(t => t.Patient)
            .Include(t => t.Insurance)
            .Include(t => t.InsurancePlan)
            .Include(t => t.Hospital)
           .Include(t => t.Currency)
           .Include(t => t.Details).ThenInclude(d => d.Doctor)
           .Include(t => t.Details).ThenInclude(d => d.Product)
           .Include(t => t.Details).ThenInclude(d => d.MedicalSpeciality)
            , y => y.Active == true && y.Id == id) ?? new Appointment();
            var selectedLanguageKeys = this.GetDictionary(language);
            ViewBag.LanguageKeys = selectedLanguageKeys;
            ViewBag.Appointment = appointment;
            ViewBag.CurrentLanguage = language;
            return View();
        }

        public async Task<ActionResult> CheckupMedicationsPrint(long id, string language = "es")
        {
            this.httpContextAccessor.HttpContext.Request.Headers.Add("languageid", language);

            var checkupRepo = dataRepository.GetDataRepositories<PatientCheckup>();
            var checkup = await checkupRepo.GetAsync(x => x.Include(t => t.Doctor).ThenInclude(t => t.MedicalSpeciality)
            .Include(t => t.Doctor).ThenInclude(t => t.BranchOffice)
            .Include(t => t.Patient).Include(t => t.Insurance).Include(t => t.InsurancePlan).Include(t => t.Appointment).ThenInclude(x => x.Hospital)
            .Include(t => t.CheckupPrescriptions).ThenInclude(r => r.MedicalSpeciality)
            .Include(t => t.CheckupPrescriptions).ThenInclude(r => r.Product)
            , y => y.Active == true && y.Id == id) ?? new PatientCheckup();
            checkup.CheckupPrescriptions = checkup.CheckupPrescriptions == null ? new List<CheckupPrescription>() : checkup.CheckupPrescriptions.Where(x => x.Active == true && x.Type == 'M').ToList();
            var selectedLanguageKeys = this.GetDictionary(language);
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

        public async Task<ActionResult> CheckupSpecializedImagesPrint(long id, string language = "es")
        {
            this.httpContextAccessor.HttpContext.Request.Headers.Add("languageid", language);

            var checkupRepo = dataRepository.GetDataRepositories<PatientCheckup>();
            var checkup = await checkupRepo.GetAsync(x => x.Include(t => t.Doctor).ThenInclude(t => t.MedicalSpeciality)
             .Include(t => t.Doctor).ThenInclude(t => t.BranchOffice)
            .Include(t => t.Patient).Include(t => t.Insurance).Include(t => t.InsurancePlan).Include(t => t.Appointment).ThenInclude(x => x.Hospital)
            .Include(t => t.CheckupPrescriptions).ThenInclude(r => r.MedicalSpeciality)
            .Include(t => t.CheckupPrescriptions).ThenInclude(r => r.Product)
            , y => y.Active == true && y.Id == id) ?? new PatientCheckup();
            checkup.CheckupPrescriptions = checkup.CheckupPrescriptions == null ? new List<CheckupPrescription>() : checkup.CheckupPrescriptions.Where(x => x.Active == true && x.Type == 'E').ToList();
            var selectedLanguageKeys = this.GetDictionary(language);
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

        public async Task<ActionResult> CheckupConsultationsPrint(long id, string language = "es")
        {
            this.httpContextAccessor.HttpContext.Request.Headers.Add("languageid", language);

            var checkupRepo = dataRepository.GetDataRepositories<PatientCheckup>();
            var checkup = await checkupRepo.GetAsync(x => x.Include(t => t.Doctor).ThenInclude(t => t.MedicalSpeciality)
             .Include(t => t.Doctor).ThenInclude(t => t.BranchOffice)
            .Include(t => t.Patient).Include(t => t.Insurance).Include(t => t.InsurancePlan).Include(t => t.Appointment).ThenInclude(x => x.Hospital)
            .Include(t => t.CheckupPrescriptions).ThenInclude(r => r.MedicalSpeciality)
            .Include(t => t.CheckupPrescriptions).ThenInclude(r => r.Product)
            , y => y.Active == true && y.Id == id) ?? new PatientCheckup();
            checkup.CheckupPrescriptions = checkup.CheckupPrescriptions == null ? new List<CheckupPrescription>() : checkup.CheckupPrescriptions.Where(x => x.Active == true && x.Type == 'C').ToList();
            var selectedLanguageKeys = this.GetDictionary(language);
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

        public async Task<ActionResult> CheckupLabTestsPrint(long id, string language = "es")
        {
            this.httpContextAccessor.HttpContext.Request.Headers.Add("languageid", language);

            var checkupRepo = dataRepository.GetDataRepositories<PatientCheckup>();
            var checkup = await checkupRepo.GetAsync(x => x.Include(t => t.Doctor).ThenInclude(t => t.MedicalSpeciality)
             .Include(t => t.Doctor).ThenInclude(t => t.BranchOffice)
            .Include(t => t.Patient).Include(t => t.Insurance).Include(t => t.InsurancePlan).Include(t => t.Appointment).ThenInclude(x => x.Hospital)
            .Include(t => t.CheckupPrescriptions).ThenInclude(r => r.MedicalSpeciality)
            .Include(t => t.CheckupPrescriptions).ThenInclude(r => r.Product)
            , y => y.Active == true && y.Id == id) ?? new PatientCheckup();
            checkup.CheckupPrescriptions = checkup.CheckupPrescriptions == null ? new List<CheckupPrescription>() : checkup.CheckupPrescriptions.Where(x => x.Active == true && x.Type == 'L').ToList();
            var selectedLanguageKeys = this.GetDictionary(language);
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

        public async Task<ActionResult> ExpensePrint(long id, string language = "es")
        {
            this.httpContextAccessor.HttpContext.Request.Headers.Add("languageid", language);

            var invoiceRepo = dataRepository.GetDataRepositories<Expense>();
            var invoice = await invoiceRepo.GetAsync(x => x.Include(i => i.Supplier).Include(i => i.Currency), y => y.Active == true && y.Id == id) ?? new Expense();
            var selectedLanguageKeys = this.GetDictionary(language);
            ViewBag.LanguageKeys = selectedLanguageKeys;
            ViewBag.Expense = invoice;
            ViewBag.CurrentLanguage = language;
            return View();
        }

        public async Task<ActionResult> InvoicePayment(string sequence, string language = "es")
        {
            this.httpContextAccessor.HttpContext.Request.Headers.Add("languageid", language);

            var paymentsRepo = dataRepository.GetDataRepositories<CustomerPayment>();
            var payments = (await paymentsRepo.GetAllAsync(x => x.Include(p => p.Customer).Include(p => p.Currency).Include(p => p.Seller).Include(p => p.Invoice), y => y.Active == true && y.Sequence.ToLower() == sequence.ToLower() && y.State == (char)BillingStates.Paid)).Data.ToList();
            var selectedLanguageKeys = this.GetDictionary(language);
            ViewBag.LanguageKeys = selectedLanguageKeys;
            ViewBag.Payments = payments;
            ViewBag.CurrentLanguage = language;
            return View();
        }

        public async Task<ActionResult> ExpensePayment(long id, string language = "es")
        {
            this.httpContextAccessor.HttpContext.Request.Headers.Add("languageid", language);

            var invoiceRepo = dataRepository.GetDataRepositories<Expense>();
            var invoice = await invoiceRepo.GetAsync(x => x.Include(i => i.Supplier).Include(i => i.Currency)
            .Include(i => i.Payments), y => y.Active == true && y.Id == id);
            invoice.Payments = invoice.Payments.Where(y => y.Active == true).ToList();
            var selectedLanguageKeys = this.GetDictionary(language);
            ViewBag.LanguageKeys = selectedLanguageKeys;
            ViewBag.Expense = invoice;
            ViewBag.CurrentLanguage = language;
            return View();
        }
    }
}
