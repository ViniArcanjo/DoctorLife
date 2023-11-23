using AutoMapper;
using DoctorLife.BLL.Interface;
using DoctorLife.DAL.Interface;
using DoctorLife.DL.Model;

namespace DoctorLife.BLL
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IDoctorRepository _doctorRepository;
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IMapper _mapper;

        public PatientService(IPatientRepository patientRepository, IDoctorRepository doctorRepository, IAppointmentRepository appointmentRepository, IMapper mapper)
        {
            _patientRepository = patientRepository;
            _doctorRepository = doctorRepository;
            _appointmentRepository = appointmentRepository;
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

        public List<Patient> GetByDoctorCrm(string crm)
        {
            var doctor = _doctorRepository.GetByDoctorCrm(crm);

            if (doctor == null)
            {
                return new List<Patient>();
            }

            var appointments = _appointmentRepository.GetAppointmentsByDoctorCrm(doctor);

            if (!appointments.Any())
            {
                return new List<Patient>();
            }

            var result = new List<Patient>();

            foreach (var appointment in appointments)
            {
                var patient = _patientRepository.GetPatientById(appointment.PatientId);

                if (patient != null)
                {
                    result.Add(patient);
                }
            }

            return result;
        }

        public Patient? GetCredentials(string email, string password)
        {
            var result = _patientRepository.GetPatientCredentials(email, password);
            return result;
        }
    }
}
