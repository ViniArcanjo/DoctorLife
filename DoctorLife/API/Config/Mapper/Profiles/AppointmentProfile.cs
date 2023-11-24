using AutoMapper;
using DoctorLife.DL.DTO.Request;
using DoctorLife.DL.Model;

namespace DoctorLife.API.Config.Mapper.Profiles
{
    public class AppointmentProfile : Profile
    {
        public AppointmentProfile()
        {
            CreateMap<CreateAppointmentRequest, Appointment>()
                .ForMember(dest => dest.AppointmentDate, opt => opt.MapFrom(src => src.Date));
        }
    }
}
