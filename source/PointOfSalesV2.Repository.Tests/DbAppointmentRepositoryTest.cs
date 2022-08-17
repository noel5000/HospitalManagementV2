using Moq;
using Moq.EntityFrameworkCore;
using NUnit.Framework;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Repository.Tests
{
    public class DbAppointmentRepositoryTest
    {
        [SetUp]
        public void Setup()
        {
        }
        private Mock<MainDataContext> MockDb() 
        {
            List<Appointment> appointments = new List<Appointment>()
            {
             new Appointment(){Id=1, Active=true, CurrencyId=1, HospitalId=1, InsuranceId=1, InsurancePlanId=1, PatientId=1 }
            };

            List<AppointmentDetail> appointmentDetails = new List<AppointmentDetail>()
            {
             new AppointmentDetail(){Id=1, AppointmentId=1, ProductId=1, CurrencyId=1 , Active=true }
            };
            List<BranchOffice> hospitals = new List<BranchOffice>()
            {
             new BranchOffice(){Id=1, Active=true }
            };
            List<Insurance> insurances = new List<Insurance>()
            {
             new Insurance(){Id=1, Active=true }
            };
            List<InsurancePlan> insurancePlans = new List<InsurancePlan>()
            {
             new InsurancePlan(){Id=1,  Active=true, InsuranceId=1}
            };
            List<Customer> customers = new List<Customer>()
            {
             new Customer(){Id=1, Active=true }
            };

            List<Product> products = new List<Product>()
            {
             new Product(){Id=1, Active=true   }
            };

            List<Currency> currencies = new List<Currency>()
            {
             new Currency(){Id=1, Active=true   }
            };

            var mockDb = new Mock<MainDataContext>();
            mockDb.Setup(ctx => ctx.Appointments).ReturnsDbSet(appointments);
            mockDb.Setup(ctx => ctx.AppointmentDetails).ReturnsDbSet(appointmentDetails);
            mockDb.Setup(ctx => ctx.Products).ReturnsDbSet(products);
            mockDb.Setup(ctx => ctx.Currencies).ReturnsDbSet(currencies);
            mockDb.Setup(ctx => ctx.BranchOffices).ReturnsDbSet(hospitals);
            mockDb.Setup(ctx => ctx.Customers).ReturnsDbSet(customers);
            mockDb.Setup(ctx => ctx.InsurancePlans).ReturnsDbSet(insurancePlans);
            mockDb.Setup(ctx => ctx.Insurances).ReturnsDbSet(insurances);

            return mockDb;
        }

       [Test]
        public void GetAppointmentByIdAsync()
        {

            var mockDb = this.MockDb();
            IAppointmentRepository repo = new AppointmentRepository(mockDb.Object);

            var t_appointment = repo.GetAsync(1);
           
            var t_result = t_appointment.Result;
            Assert.IsNotNull(t_result);
            Assert.AreEqual(1, t_result.Data.ToList().Count);

        }
    }
}