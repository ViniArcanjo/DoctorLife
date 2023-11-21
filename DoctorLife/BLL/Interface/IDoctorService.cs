using DoctorLife.DL.Model;

namespace DoctorLife.BLL.Interface
{
    public interface IDoctorService
    {
        List<Doctor> GetAll();
        Doctor? GetById(long id);
        Doctor? GetCredentials(string email, string password);
    }
}
