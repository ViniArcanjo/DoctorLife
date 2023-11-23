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

        [Column("TITLE")]
        public string? Title { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Column("DOCTORID")]
        [ForeignKey(nameof(Doctor))]
        public long DoctorId { get; set; }

        [NotMapped]
        public virtual Doctor? Doctor { get; set; }

        [Column("PATIENTID")]
        [ForeignKey(nameof(Patient))]
        public long PatientId { get; set; }

        [NotMapped]
        public virtual Patient? Patient { get; set; }

        [Column("APPOINTMENT_DATE")]
        public DateTime AppointmentDate { get; set; }
    }
}
