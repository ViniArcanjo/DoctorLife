using DoctorLife.DL.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorLife.DL.Model
{
    public class Test : EntityAuditBase
    {
        [Key]
        [Column("TESTID")]
        public long TestId { get; set; }

        [Column("TITLE")]
        public string? Title { get; set; }

        [Column("TEST_DESCRIPTION")]
        public string? Description { get; set; }

        [Column("TEST_DATE")]
        public DateTime? TestDate { get; set; }

        [Column("APPOINTMENTSID")]
        [ForeignKey(nameof(Appointment))]
        public long AppointmentId { get; set; }

        [NotMapped]
        public virtual Appointment? Appointment { get; set; }
    }
}
