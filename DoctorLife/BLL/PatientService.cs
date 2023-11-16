using AutoMapper;
using DoctorLife.BLL.Interface;
using DoctorLife.DAL.Interface;
using DoctorLife.DL.DTO.Request;
using DoctorLife.DL.Model;

namespace DoctorLife.BLL
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IMapper _mapper;

        public PatientService(IPatientRepository patientRepository, IMapper mapper)
        {
            _patientRepository = patientRepository;
            _mapper = mapper;
        }

        public List<Patient> GetAll()
        {
            var result = _patientRepository.GetAllPatients();
            return result;
        }

        public Patient GetById(long id)
        {
            var result = _patientRepository.GetPatientById(id);
            return result;
        }

        public async Task<Patient> Create(CreatePatientRequest request)
        {
            var patientToInsert = _mapper.Map<Patient>(request);

            var result = await _patientRepository.Create(patientToInsert);

            return result;
        }

    }
}
