namespace DoctorLife.DL.DTO.Request
{
    public class CreatePatientRequest
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public DateTime Birthday { get; set; }
        public string? ProfilePicUrl { get; set; }
    }
}
