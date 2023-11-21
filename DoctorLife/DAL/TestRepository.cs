using DoctorLife.DAL.Base;
using DoctorLife.DAL.Interface;
using DoctorLife.DL.Model;
using Microsoft.EntityFrameworkCore;

namespace DoctorLife.DAL
{
    public class TestRepository : BaseRepository<Test>, ITestRepository
    {
        public TestRepository(Context context) : base(context) { }
        
        public List<Test> GetAllTests()
        {
            var result = GetAll()
                .Include(test => test.Appointment)
                .ToList();
            return result;
        }

        public Test GetTestById(long id)
        {
            var result = Get(test => test.TestId == id).FirstOrDefault();
            return result;
        }

        public List<Test> GetTestsByPatientCpf(string patientCpf)
        {
            var result = Get(test => test.Appointment.Patient.Cpf == patientCpf)
                .ToList();

            return result;
        }

        public List<Test> GetTestsByDoctorCrm(string doctorCrm)
        {
            var result = Get(test => test.Appointment.Doctor.Crm == doctorCrm).ToList();

            return result;
        }

        public List<Test> GetTestsByAppointmentId(long appoitmentId)
        {
            var result = Get(test => test.Appointment.AppointmentId == appoitmentId).ToList();

            return result;
        }
    }
}
