using AutoMapper;
using DoctorLife.BLL.Interface;
using DoctorLife.DAL;
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

        public Patient? GetById(long id)
        {
            var result = _patientRepository.GetPatientById(id);
            return result;
        }

        public Patient? GetByCpf(string cpf)
        {
            var result = _patientRepository.GetPatientByCpf(cpf);
            return result;
        }

        public Patient? GetCredentials(string email, string password)
        {
            var result = _patientRepository.GetPatientCredentials(email, password);
            return result;
        }
    }
}
