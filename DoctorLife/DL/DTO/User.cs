namespace DoctorLife.DL.DTO
{
    public class User
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string? Cpf { get; set; }
        public DateTime? BirthDay { get; set; }
        public string? Crm { get; set; }
        public string? Expertise { get; set; }
    }
}
