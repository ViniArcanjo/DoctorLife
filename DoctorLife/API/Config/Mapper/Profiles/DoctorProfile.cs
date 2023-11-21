using AutoMapper;
using DoctorLife.DL.DTO;
using DoctorLife.DL.Model;

namespace DoctorLife.API.Config.Mapper.Profiles
{
    public class DoctorProfile : Profile
    {
        public DoctorProfile()
        {
            CreateMap<Doctor, User>()
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive == 'Y'));
        }
    }
}
