﻿using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public interface IAppointmentRepository : IBase<Appointment>
    {
        Task<List<Appointment>> GetAppointmentsByDay(DateTime date,long hospitalId, string doctorId, long? medicalSpeciality, long? patientId);
        Task<List<Appointment>> GetAppointmentsByMonth(DateTime date, long hospitalId, string doctorId, long? medicalSpeciality, long? patientId);
    }
}
