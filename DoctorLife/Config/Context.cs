using Microsoft.EntityFrameworkCore;

namespace DoctorLife.Config
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
    }
}
