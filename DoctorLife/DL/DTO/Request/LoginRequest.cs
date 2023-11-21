using DoctorLife.DL.Enums;

namespace DoctorLife.DL.DTO.Request
{
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public AppRoles Role { get; set; }
    }
}
