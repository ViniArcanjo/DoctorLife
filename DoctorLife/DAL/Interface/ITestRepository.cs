using DoctorLife.DL.Model;

namespace DoctorLife.DAL.Interface
{
    public interface ITestRepository
    {
        List<Test> GetAllTests();
        Test GetTestById(long id);
        List<Test> GetTestsByAppointmentId(long appoitmentId);
        List<Test> GetTestsByDoctorCrm(string doctorCrm);
        List<Test> GetTestsByPatientCpf(string patientCpf);
    }
}
