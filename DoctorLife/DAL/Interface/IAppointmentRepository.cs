﻿using DoctorLife.DL.Model;

namespace DoctorLife.DAL.Interface
{
    public interface IAppointmentRepository
    {
        Task CreateAppointment(Appointment appointment);
        List<Appointment> GetAllAppointments();
        Appointment GetAppointmentById(long id);
        List<Appointment> GetAppointmentsByDoctorCrm(Doctor doctor);
        List<Appointment> GetAppointmentsByPatientCpf(Patient patient);
    }
}
