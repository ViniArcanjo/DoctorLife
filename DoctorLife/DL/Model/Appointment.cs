namespace DoctorLife.DL.Model
{
    public class Appointment
    {
        public long DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public long PatientId { get; set; }
        public Patient Patient { get; set; }
        public DateTime DateTime { get; set; }
    }
}
