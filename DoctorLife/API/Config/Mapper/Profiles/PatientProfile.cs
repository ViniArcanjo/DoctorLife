using AutoMapper;
using DoctorLife.DL.DTO;
using DoctorLife.DL.Model;

namespace DoctorLife.API.Config.Mapper.Profiles
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            CreateMap<Patient, User>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.PatientId))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive == 'Y'));
        }
    }
}
