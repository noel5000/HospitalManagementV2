
namespace PointOfSalesV2.Repository
{
    public interface IPatientCheckupRepository : IBase<PatientCheckup>
    {
        Task<List<PatientCheckup>> GetPatientHistory(long patientId);


    }
}
