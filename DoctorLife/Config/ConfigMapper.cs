using AutoMapper;
using DoctorLife.DL.DTO.Request;
using DoctorLife.DL.Model;

namespace AMLRocketPyrex.Api.BLL.ConfigAutoMapper
{
    public static class ConfigMapper
    {
        public static IMapper Configure()
        {
            return new MapperConfiguration
                (cfg =>
                {
                    #region Patient
                    cfg.CreateMap<CreatePatientRequest, Patient>();
                    #endregion
                }
                )
                .CreateMapper();
        }
    }
}
