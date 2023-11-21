using DoctorLife.DL.Base;
using DoctorLife.DL.DTO.Request;
using Microsoft.AspNetCore.Mvc;

namespace DoctorLife.BLL.Interface
{
    public interface ILoginService
    {
        EntityAuditBase? ValidateUser(LoginRequest request);
    }
}
