using DoctorLife.DL.Model;

namespace DoctorLife.DAL.Interface
{
    public interface IPatientRepository
    {
        List<Patient> GetAllPatients();
        Patient GetPatientById(long id);
        public Task<Patient> Create(Patient request);
    }
}
