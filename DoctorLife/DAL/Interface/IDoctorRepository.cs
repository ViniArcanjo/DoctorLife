using DoctorLife.DL.Model;

namespace DoctorLife.DAL.Interface
{
    public interface IDoctorRepository
    {
        List<Doctor> GetAllDoctors();
        Doctor? GetDoctorById(long id);
        Doctor? GetDoctorCredentials(string email, string password);
    }
}
