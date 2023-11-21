using DoctorLife.DL.Model;

namespace DoctorLife.BLL.Interface
{
    public interface IAppointmentService
    {
        List<Appointment> GetAll();
        List<Appointment> GetByDoctorCrm(string doctorCrm);
        Appointment GetById(long id);
        List<Appointment> GetByPatientCpf(string patientCpf);
    }
}
