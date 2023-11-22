using DoctorLife.DL.Model;
using Microsoft.EntityFrameworkCore;

namespace DoctorLife.DAL.Base
{
    public class Context : DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Test> Tests { get; set; }

        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                .ToTable("TB_APPOINTMENTS");

            //modelBuilder.Entity<Appointment>()
            //    .Navigation(x => x.Patient).AutoInclude();
            
            //modelBuilder.Entity<Appointment>()
            //    .Navigation(x => x.Doctor).AutoInclude();

            //modelBuilder.Entity<Appointment>()
            //    .Navigation(x => x.Test).AutoInclude();

            modelBuilder.Entity<Doctor>()
                .ToTable("TB_DOCTORS");

            modelBuilder.Entity<Patient>()
                .ToTable("TB_PATIENTS");

            modelBuilder.Entity<Test>()
                .ToTable("TB_TESTS");

            //modelBuilder.Entity<Test>()
            //    .Navigation(x => x.Appointment).AutoInclude();
        }
    }
}
