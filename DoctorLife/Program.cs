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
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<Context>(options => options.UseOracle(builder.Configuration.GetConnectionString("Oracle")));
            builder.Services.ConfigureScoped(builder.Configuration);

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseAuthorization();

            

            app.MapControllers();

            app.Run();
        }
    }
}