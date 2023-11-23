using DoctorLife.DAL.Base;
using DoctorLife.DAL.Interface;
using DoctorLife.DL.Model;

namespace DoctorLife.DAL
{
    public class TestRepository : BaseRepository<Test>, ITestRepository
    {
        public TestRepository(Context context) : base(context) { }

        public List<Test> GetAllTests()
        {
            var result = GetAll()
                .ToList();

            return result;
        }

        public Test GetTestById(long id)
        {
            var result = Get(test => test.TestId == id)
                .FirstOrDefault();

            return result;
        }

        public List<Test> GetTestsByAppointments(List<Appointment> appointments)
        {
            var result = new List<Test>();

            foreach (var appointment in appointments)
            {
                var test = Get(test => test.AppointmentId == appointment.AppointmentId).FirstOrDefault();

                if (test != null)
                {
                    test.Appointment = appointment;
                    result.Add(test);
                }
            }

            return result;
        }
    }
}
