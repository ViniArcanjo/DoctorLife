using DoctorLife.DL.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorLife.DL.Model
{
    public class Appointment : EntityAuditBase
    {
        [Key]
        [Column("APPOINTMENTSID")]
        public long AppointmentId { get; set; }

        [Column("DOCTORID")]
        public long DoctorId { get; set; }

        public Doctor? Doctor { get; set; }

        [Column("PATIENTID")]
        public long PatientId { get; set; }

        public Patient? Patient { get; set; }

        [Column("TESTID")]
        public long? TestId { get; set; }

        [Column("APPOINTMENT_DATE")]
        public DateTime AppointmentDate { get; set; }
    }
}
