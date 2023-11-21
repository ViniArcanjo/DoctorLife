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

        public TestService(ITestRepository testRepository, IMapper mapper)
        {
            _testRepository = testRepository;
            _mapper = mapper;
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
            var result = _testRepository.GetTestsByPatientCpf(patientCpf);

            return result;
        }

        public List<Test> GetByDoctorCrm(string doctorCrm)
        {
            var result = _testRepository.GetTestsByDoctorCrm(doctorCrm);

            return result;
        }

        public List<Test> GetByAppointmentId(long appoitmentId)
        {
            var result = _testRepository.GetTestsByAppointmentId(appoitmentId);

            return result;
        }
    }
}
