using DoctorLife.DL.Model;

namespace DoctorLife.DAL.Interface
{
    public interface IAppointmentRepository
    {
        List<Appointment> GetAllAppointments();
        Appointment GetAppointmentById(long id);
        List<Appointment> GetAppointmentsByDoctorCrm(string doctorCrm);
        List<Appointment> GetAppointmentsByPatientCpf(string patientCpf);
    }
}
