using AutoMapper;
using DoctorLife.BLL.Interface;
using DoctorLife.DL.DTO;
using DoctorLife.DL.DTO.Request;

namespace DoctorLife.BLL
{
    public class LoginService : ILoginService
    {
        private readonly IMapper _mapper;
        private readonly IPatientService _patientService;
        private readonly IDoctorService _doctorService;

        public LoginService(IMapper mapper, IPatientService patientService, IDoctorService doctorService)
        {
            _mapper = mapper;
            _patientService = patientService;
            _doctorService = doctorService;
        }

        public User? ValidateUser(LoginRequest request)
        {
            if (request.Role.ToString() == "Patient")
            {
                var patient = _patientService.GetCredentials(request.Email, request.Password);
                var user = _mapper.Map<User>(patient);

                return user ?? null;
            }

            if (request.Role.ToString() == "Doctor")
            {
                var doctor = _doctorService.GetCredentials(request.Email, request.Password);

                var user = _mapper.Map<User>(doctor);

                return user ?? null;
            }

            return null;
        }
    }
}
