using DoctorLife.DL.DTO.Request;
using DoctorLife.DL.Model;

namespace DoctorLife.BLL.Interface
{
    public interface IPatientService
    {
        List<Patient> GetAll();
        Patient? GetByCpf(string cpf);
        Patient? GetById(long id);
        Patient? GetCredentials(string email, string password);
    }
}
