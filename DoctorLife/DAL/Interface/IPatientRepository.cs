using DoctorLife.DL.Model;

namespace DoctorLife.DAL.Interface
{
    public interface IPatientRepository
    {
        List<Patient> GetAllPatients();
        Patient? GetPatientById(long id);
        Patient? GetPatientCredentials(string email, string password);
    }
}
