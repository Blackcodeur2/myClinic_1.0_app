using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyClinic_1._0.src.data.database;
using MyClinic_1._0.src.features.forms.splash;

namespace MyClinic_1._0
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            var services = new ServiceCollection();

            services.AddSingleton<IConfiguration>(config);

            services.AddDbContext<AppDbContext>(options =>
            {
                var conn = config.GetConnectionString("DefaultConnection");

                options.UseMySql(
                    conn,
                    ServerVersion.AutoDetect(conn)
                );
            });

            ServiceProvider = services.BuildServiceProvider();

            Application.Run(new SplashView());
        }
    }
}