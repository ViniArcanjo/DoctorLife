using System.ComponentModel.DataAnnotations;

namespace DoctorLife.DL.DTO.Request
{
    public class CreateAppointmentRequest
    {
        [Required]
        public long DoctorId { get; set; }

        [Required]
        public long PatientId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }
    }
}
