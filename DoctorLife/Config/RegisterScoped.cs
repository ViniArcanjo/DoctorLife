namespace DoctorLife.Config
{
    public static class RegisterScoped
    {
        public static void ConfigureScoped(this IServiceCollection services)
        {
            services.ConfigureServices();
            services.ConfigureRepository();
        }

        private static void ConfigureServices(this IServiceCollection services)
        {
            
        }

        private static void ConfigureRepository(this IServiceCollection services)
        {

        }
    }
}
