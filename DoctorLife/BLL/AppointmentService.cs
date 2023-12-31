﻿using AutoMapper;
using DoctorLife.BLL.Interface;
using DoctorLife.DAL.Interface;
using DoctorLife.DL.DTO.Request;
using DoctorLife.DL.Model;
using DoctorLife.INFRA.Const;
using DoctorLife.INFRA.Utils;

namespace DoctorLife.BLL
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IMapper _mapper;
        private readonly IPatientService _patientService;
        private readonly IDoctorService _doctorService;

        public AppointmentService(IAppointmentRepository appointmentRepository, IMapper mapper, IPatientService patientService, IDoctorService doctorService)
        {
            _appointmentRepository = appointmentRepository;
            _mapper = mapper;
            _patientService = patientService;
            _doctorService = doctorService;
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
            var patient = _patientService.GetByCpf(patientCpf);

            if (patient == null)
            {
                return new List<Appointment>();
            }

            var result = _appointmentRepository.GetAppointmentsByPatientCpf(patient);

            foreach (var appointment in result)
            {
                var doctor = _doctorService.GetById(appointment.DoctorId);

                if (doctor != null)
                {
                    appointment.Doctor = doctor;
                }
            }

            return result;
        }

        public List<Appointment> GetByDoctorCrm(string doctorCrm)
        {
            var doctor = _doctorService.GetByCrm(doctorCrm);

            if (doctor == null)
            {
                return new List<Appointment>();
            }

            var result = _appointmentRepository.GetAppointmentsByDoctorCrm(doctor);

            foreach (var appointment in result)
            {
                var patient = _patientService.GetById(appointment.PatientId);

                if (patient != null)
                {
                    appointment.Patient = patient;
                }
            }

            return result;
        }

        public async Task<MethodMessage> Create(CreateAppointmentRequest request)
        {
            var doctor = _doctorService.GetById(request.DoctorId);
            var patient = _patientService.GetById(request.PatientId);

            if (doctor == null)
            {
                return new MethodMessage(true, "Doctor not found");
            }

            if (patient == null)
            {
                return new MethodMessage(true, "Patient not found");
            }

            var appointment = _mapper.Map<Appointment>(request);
            EntityHelper.UpsertAuditInfo(appointment);

            await _appointmentRepository.CreateAppointment(appointment);

            return new MethodMessage();
        }
    }
}
