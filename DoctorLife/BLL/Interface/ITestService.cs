using DoctorLife.DL.DTO.Request;
using DoctorLife.DL.Model;

namespace DoctorLife.BLL.Interface
{
    public interface ITestService
    {
        List<Test> GetAll();
        List<Test> GetByAppointmentId(long appoitmentId);
        List<Test> GetByDoctorCrm(string doctorCrm);
        Test GetById(long id);
        List<Test> GetByPatientCpf(string patientCpf);
    }
}
