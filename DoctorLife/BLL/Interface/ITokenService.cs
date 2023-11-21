using DoctorLife.DL.DTO.Request;

namespace DoctorLife.BLL.Interface
{
    public interface ITokenService
    {
        string GenerateToken(LoginRequest loginRequest);
    }
}
