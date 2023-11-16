using DoctorLife.DL.DTO.Request;
using DoctorLife.DL.Model;

namespace DoctorLife.BLL.Interface
{
    public interface IPatientService
    {
        List<Patient> GetAll();
        Patient GetById(long id);
        Task<Patient> Create(CreatePatientRequest request);
    }
}
