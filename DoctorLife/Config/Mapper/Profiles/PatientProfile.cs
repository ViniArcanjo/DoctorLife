using AutoMapper;
using DoctorLife.DL.DTO;
using DoctorLife.DL.Model;

namespace DoctorLife.Config.Mapper.Profiles
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            CreateMap<Patient, User>()
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive == 'Y'));
        }
    }
}
