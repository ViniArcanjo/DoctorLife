using DoctorLife.DL.Model;

namespace DoctorLife.DAL.Interface
{
    public interface ITestRepository
    {
        List<Test> GetAllTests();
        Test GetTestById(long id);
        List<Test> GetTestsByAppointments(List<Appointment> appointments);
    }
}
