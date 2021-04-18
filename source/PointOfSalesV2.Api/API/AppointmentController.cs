﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PointOfSalesV2.Api.Security;
using PointOfSalesV2.Entities; using Microsoft.Extensions.Caching.Memory;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.Repository;
using Microsoft.EntityFrameworkCore;
using static PointOfSalesV2.Common.Enums;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Cors;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.Appointment)]
    public class AppointmentController : BaseController<Appointment>
    {
        protected readonly IAppointmentRepository appointmentRepository;
        public AppointmentController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,repositoryFactory.GetCustomDataRepositories<IAppointmentRepository>(), AppSections.Appointment)
        {
            this.appointmentRepository = this._repositoryFactory.GetCustomDataRepositories<IAppointmentRepository>();
        }
        [ActionAuthorize(Operations.READALL)]
        [EnableQuery()]
        [EnableCors("AllowAllOrigins")]
        public override IActionResult Get()
        {
            try
            {
                var data = _baseRepo.GetAll<Appointment>(x => x.AsNoTracking()
                .Include(x=>x.Hospital)
                .Include(x=>x.Doctor)
                .Include(x=>x.Patient)
                .Include(x=>x.MedicalSpeciality)
                .Include(x=>x.Insurance)
                .Include(x=>x.InsurancePlan)
                .Include(x=>x.Currency)
                .Include(x=>x.Product)
                , y=>y.Active==true);
                return Ok(data);
            }

            catch (Exception ex)
            {
                SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }
        [EnableCors("AllowAllOrigins")]
        [HttpGet("GetAppointmentsByDay/{date}/{hospitalId:long}/{doctorId}/{medicalSpeciality:long?}/{patientId:long?}")]
        public async Task<IActionResult> GetAppointmentsByDay(DateTime date,long hospitalId, string doctorId, long? medicalSpeciality, long? patientId) 
        {
            try
            {
                var appointments = await appointmentRepository.GetAppointmentsByDay(date, hospitalId,doctorId, medicalSpeciality,patientId);
                var data = new Result<Appointment>(0, 0, "ok_msg", appointments);
                return Ok(data);
            }

            catch (Exception ex)
            {
                SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }
        [EnableCors("AllowAllOrigins")]
        [HttpGet("GetAppointmentsByMonth/{date}/{hospitalId:long}/{doctorId}/{medicalSpeciality:long?}/{patientId:long?}")]
        public async Task<IActionResult> GetAppointmentsByMonth(DateTime date,long hospitalId, string doctorId, long? medicalSpeciality, long? patientId)
        {
            try
            {
                doctorId = doctorId != null && doctorId == "null" ? "" : doctorId;
                var appointments = await appointmentRepository.GetAppointmentsByMonth(date, hospitalId, doctorId, medicalSpeciality, patientId);
                var data = new Result<Appointment>(0, 0, "ok_msg", appointments);
                return Ok(data);
            }

            catch (Exception ex)
            {
                SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }
    }
}