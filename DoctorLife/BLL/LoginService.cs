using DoctorLife.BLL.Interface;
using DoctorLife.DL.Base;
using DoctorLife.DL.DTO.Request;

namespace DoctorLife.BLL
{
    public class LoginService : ILoginService
    {
        private readonly IPatientService _patientService;
        private readonly IDoctorService _doctorService;

        public LoginService(IPatientService patientService, IDoctorService doctorService)
        {
            _patientService = patientService;
            _doctorService = doctorService;
        }

        public EntityAuditBase? ValidateUser(LoginRequest request)
        {
            if (request.Role.ToString() == "Patient")
            {
                var user = _patientService.GetCredentials(request.Email, request.Password);

                return user;
            }

            if (request.Role.ToString() == "Doctor")
            {
                var user = _doctorService.GetCredentials(request.Email, request.Password);

                return user;
            }

            return null;
        }
    }
}
