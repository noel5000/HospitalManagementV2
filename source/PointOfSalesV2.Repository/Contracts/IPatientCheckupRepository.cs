﻿using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSalesV2.Repository
{
    public interface IPatientCheckupRepository : IBase<PatientCheckup>
    {
        Task<List<PatientCheckup>> GetPatientHistory(long patientId);
    }
}