using DoctorLife.DL.DTO.Request;
using DoctorLife.DL.Model;

namespace DoctorLife.BLL.Interface
{
    public interface IDoctorService
    {
        List<Doctor> GetAll();
        Doctor GetById(long id);
        Task<Doctor> Create(CreatePatientRequest request);
    }
}
