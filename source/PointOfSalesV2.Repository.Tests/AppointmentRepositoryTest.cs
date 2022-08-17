using Moq;
using NUnit.Framework;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Repository.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetAppointmentById()
        {
           var mockRepo= new Mock<IAppointmentRepository>();
            mockRepo.Setup(repo => repo.Get(
                It.IsAny<long>())).Returns((long id)=>new Result<Appointment>(id,0,"ok_msg",
                new List<Appointment>() 
                {
                new Appointment(){Id=id }
                }));

            var appointment = mockRepo.Object.Get(1);
            Assert.IsNotNull(appointment);
            
        }

        [Test]
        public void GetAppointmentByIdAsync()
        {
            var mockRepo = new Mock<IAppointmentRepository>();
            mockRepo.Setup(repo => repo.GetAsync(
                It.IsAny<long>())).Returns((long id) => new Task<Result<Appointment>>(() => {
                    return new Result<Appointment>(id, 0, "ok_msg",
                    new List<Appointment>()
                    {
                new Appointment(){Id=id }
                    });
                }));

            var t_appointment = mockRepo.Object.GetAsync(1);
            t_appointment.Start();
            var t_result = t_appointment.Result;
            Assert.IsNotNull(t_result);
            Assert.AreEqual(1, t_result.Data.ToList().Count);

        }
    }
}