using AutoMapper;
using DoctorLife.BLL.Interface;
using DoctorLife.DAL.Interface;
using DoctorLife.DL.Model;

namespace DoctorLife.BLL
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IMapper _mapper;

        public AppointmentService(IAppointmentRepository appointmentRepository, IMapper mapper)
        {
            _appointmentRepository = appointmentRepository;
            _mapper = mapper;
        }
 
        public List<Appointment> GetAll()
        {
            var result = _appointmentRepository.GetAllAppointments();
            return result;
        }

        public Appointment GetById(long id)
        {
            var result = _appointmentRepository.GetAppointmentById(id);
            return result;
        }
        public List<Appointment> GetByPatientCpf(string patientCpf)
        {
            var result = _appointmentRepository.GetAppointmentsByPatientCpf(patientCpf);

            return result;
        }

        public List<Appointment> GetByDoctorCrm(string doctorCrm)
        {
            var result = _appointmentRepository.GetAppointmentsByDoctorCrm(doctorCrm);

            return result;
        }
    }
}
