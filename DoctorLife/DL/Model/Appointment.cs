using DoctorLife.DL.Base;
using System.ComponentModel.DataAnnotations;

namespace DoctorLife.DL.Model
{
    public class Appointment : EntityAuditBase
    {
        [Key]
        public long AppointmentId { get; set; }

        public long DoctorId { get; set; }

        public Doctor Doctor { get; set; }

        public long PatientId { get; set; }

        public Patient Patient { get; set; }

        public DateTime DateTime { get; set; }
    }
}
