﻿using DoctorLife.API.Config.Mapper;
using DoctorLife.BLL;
using DoctorLife.BLL.Interface;
using DoctorLife.DAL;
using DoctorLife.DAL.Interface;
using DoctorLife.DL.DTO.Request;
using DoctorLife.DL.Validation;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace DoctorLife.API.Config
{
    public static class RegisterScoped
    {
        public static void ConfigureScoped(this IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureRepository();
            services.ConfigureServices(configuration);
            services.ConfigureValidation();
        }

        private static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(MapperBuilder.Build());

            services.AddScoped<IPatientService, PatientService>();
            services.AddScoped<IDoctorService, DoctorService>();
            services.AddScoped<IAppointmentService, AppointmentService>();
            services.AddScoped<ITestService, TestService>();
            services.AddScoped<ILoginService, LoginService>();

            services.AddScoped<ITokenService, TokenService>();
            services.ConfigureAuth(configuration);
        }

        private static void ConfigureAuth(this IServiceCollection services, IConfiguration configuration)
        {
            var key = Encoding.ASCII.GetBytes(configuration.GetValue<string>("Settings:AppSecret"));

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(x =>
                {
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });
        }

        private static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddScoped<IPatientRepository, PatientRepository>();
            services.AddScoped<IDoctorRepository, DoctorRepository>();
            services.AddScoped<ITestRepository, TestRepository>();
            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
        }

        private static void ConfigureValidation(this IServiceCollection services)
        {
            services.AddScoped<IValidator<CreateAppointmentRequest>, CreateAppointmentRequestValidation>();
        }
    }
}
