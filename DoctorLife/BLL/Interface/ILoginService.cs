using DoctorLife.DL.DTO;
using DoctorLife.DL.DTO.Request;

namespace DoctorLife.BLL.Interface
{
    public interface ILoginService
    {
        User? ValidateUser(LoginRequest request);
    }
}
