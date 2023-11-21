﻿using AutoMapper;
using DoctorLife.Config.Mapper.Profiles;

namespace DoctorLife.Config.Mapper
{
    public static class MapperBuilder
    {
        public static IMapper Build()
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new DoctorProfile());
                mc.AddProfile(new PatientProfile());
            });

            return mapperConfig.CreateMapper();
        }
    }
}
