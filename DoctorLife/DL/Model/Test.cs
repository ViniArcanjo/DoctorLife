using DoctorLife.DL.Base;

namespace DoctorLife.DL.Model
{
    public class Test : EntityAuditBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public long AppointmentId { get; set; }
        public Appointment Appointment { get; set; }
    }
}
