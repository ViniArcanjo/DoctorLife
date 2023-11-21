using DoctorLife.Config;
using DoctorLife.DAL.Base;
using Microsoft.EntityFrameworkCore;

namespace DoctorLife
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(
            //    opt =>
            //{
            //    opt.SwaggerDoc("v1", new OpenApiInfo { Title = "Doctor Life API", Version = "v1" });

            //    opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            //    {
            //        In = ParameterLocation.Header,
            //        Description = "Please, enter a valid token.",
            //        Name = "Authorization",
            //        Type = SecuritySchemeType.Http,
            //        BearerFormat = "JWT",
            //        Scheme = "Bearer"
            //    });

            //    opt.AddSecurityRequirement(new OpenApiSecurityRequirement
            //    {
            //        {
            //            new OpenApiSecurityScheme
            //            {
            //                Reference = new OpenApiReference
            //                {
            //                    Type = ReferenceType.SecurityScheme,
            //                    Id = "Bearer"
            //                }
            //            },
            //            new string[]{}
            //        }
            //    });
            //}
            );

            builder.Services.AddDbContext<Context>(options => options.UseOracle(builder.Configuration.GetConnectionString("Oracle")));
            builder.Services.ConfigureScoped(builder.Configuration);

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}