using DoctorLife.DL.Base;
using System.ComponentModel.DataAnnotations;

namespace DoctorLife.DL.Model
{
    public class Test : EntityAuditBase
    {
        [Key]
        public long TestId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateTime { get; set; }

        public long AppointmentId { get; set; }

        public Appointment Appointment { get; set; }
    }
}
