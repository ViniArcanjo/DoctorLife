﻿using DoctorLife.DAL.Base;
using DoctorLife.DAL.Interface;
using DoctorLife.DL.DTO.Request;
using DoctorLife.DL.Model;

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
                .FirstOrDefault();

            return result;
        }

        public List<Appointment> GetAppointmentsByPatientCpf(Patient patient)
        {
            var result = Get(appointment => appointment.PatientId == patient.PatientId)
                .ToList();

            foreach (var appointment in result)
            {
                appointment.Patient = patient;
            }

            return result;
        }

        public List<Appointment> GetAppointmentsByDoctorCrm(Doctor doctor)
        {
            var result = Get(appointment => appointment.DoctorId == doctor.DoctorId)
                .ToList();

            foreach (var appointment in result)
            {
                appointment.Doctor = doctor;
            }

            return result;
        }

        public async Task CreateAppointment(Appointment appointment)
        {
            Add(appointment);
            await SaveAll();
        }
    }
}
