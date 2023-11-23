using AutoMapper;
using DoctorLife.BLL.Interface;
using DoctorLife.DAL.Interface;
using DoctorLife.DL.Model;

namespace DoctorLife.BLL
{
    public class TestService : ITestService
    {
        private readonly ITestRepository _testRepository;
        private readonly IMapper _mapper;
        private readonly IAppointmentService _appointmentService;

        public TestService(ITestRepository testRepository, IMapper mapper, IAppointmentService appointmentService)
        {
            _testRepository = testRepository;
            _mapper = mapper;
            _appointmentService = appointmentService;
        }

        public List<Test> GetAll()
        {
            var result = _testRepository.GetAllTests();
            return result;
        }

        public Test GetById(long id)
        {
            var result = _testRepository.GetTestById(id);
            return result;
        }

        public List<Test> GetByPatientCpf(string patientCpf)
        {
            var appointments = _appointmentService.GetByPatientCpf(patientCpf);

            if (!appointments.Any())
            {
                return new List<Test>();
            }

            var result = _testRepository.GetTestsByAppointments(appointments);

            return result;
        }

        public List<Test> GetByDoctorCrm(string doctorCrm)
        {
            var appointments = _appointmentService.GetByDoctorCrm(doctorCrm);

            if (!appointments.Any())
            {
                return new List<Test>();
            }

            var result = _testRepository.GetTestsByAppointments(appointments);

            return result;
        }

        public List<Test> GetByAppointmentId(long appoitmentId)
        {
            var appointment = _appointmentService.GetById(appoitmentId);

            if (appointment == null)
            {
                return new List<Test>();
            }

            var result = _testRepository.GetTestsByAppointments(new List<Appointment> { appointment });

            return result;
        }
    }
}
