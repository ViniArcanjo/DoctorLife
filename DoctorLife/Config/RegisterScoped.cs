using AMLRocketPyrex.Api.BLL.ConfigAutoMapper;
using DoctorLife.BLL;
using DoctorLife.BLL.Interface;
using DoctorLife.DAL;
using DoctorLife.DAL.Interface;
using DoctorLife.DL.DTO.Request;
using DoctorLife.DL.Validation;
using FluentValidation;

namespace DoctorLife.Config
{
    public static class RegisterScoped
    {
        public static void ConfigureScoped(this IServiceCollection services)
        {
            services.ConfigureServices();
            services.ConfigureRepository();
            services.ConfigureValidation();
        }

        private static void ConfigureServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ConfigMapper));
            services.AddScoped<IPatientService, PatientService>();
            services.AddScoped<IDoctorService, DoctorService>();
        } 

        private static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddScoped<IPatientRepository, PatientRepository>();
            services.AddScoped<IDoctorRepository, DoctorRepository>();
        }

        private static void ConfigureValidation(this IServiceCollection services)
        {
            services.AddScoped<IValidator<CreatePatientRequest>, CreatePatientRequestValidation>();
        }
    }
}
