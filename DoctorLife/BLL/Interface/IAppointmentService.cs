using DoctorLife.DL.DTO.Request;
using DoctorLife.DL.Model;
using DoctorLife.INFRA.Const;
using Microsoft.AspNetCore.Mvc;

namespace DoctorLife.BLL.Interface
{
    public interface IAppointmentService
    {
        Task<MethodMessage> Create(CreateAppointmentRequest request);
        List<Appointment> GetAll();
        List<Appointment> GetByDoctorCrm(string doctorCrm);
        Appointment GetById(long id);
        List<Appointment> GetByPatientCpf(string patientCpf);
    }
}
