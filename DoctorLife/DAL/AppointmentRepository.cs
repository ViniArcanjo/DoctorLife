using DoctorLife.DAL.Base;
using DoctorLife.DAL.Interface;
using DoctorLife.DL.Model;
using Microsoft.EntityFrameworkCore;

namespace DoctorLife.DAL
{
    public class AppointmentRepository : BaseRepository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(Context context) : base(context) { }
        
        public List<Appointment> GetAllAppointments()
        {
            var result = GetAll()
                .ToList();

            return result;
        }

        public Appointment GetAppointmentById(long id)
        {
            var result = Get(appointment => appointment.AppointmentId == id)
                .Include(appointment => appointment.Test)
                .FirstOrDefault();

            return result;
        }

        public List<Appointment> GetAppointmentsByPatientCpf(string patientCpf)
        {
            var result = Get(appointment => appointment.Patient.Cpf == patientCpf)
                .ToList();

            return result;
        }

        public List<Appointment> GetAppointmentsByDoctorCrm(string doctorCrm)
        {
            var result = Get(appointment => appointment.Doctor.Crm == doctorCrm)
                .ToList();

            return result;
        }
    }
}
