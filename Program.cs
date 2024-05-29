using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;
using System.Configuration; 

namespace aisapp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var serviceProvider = ConfigureServices();

            Application.Run(serviceProvider.GetRequiredService<MainPage>());
        }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            //получение строки подключения 
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AisAppContext"].ConnectionString;

            //настройка DbContext строки подключения
            services.AddDbContext<AisAppContext>(options =>
                options.UseNpgsql(connectionString));

            services.AddSingleton<UserSessionService>(); //регистрация UserSessionService

            //регистрация форм
            services.AddTransient<RegistrationForm>();
            services.AddTransient<LoginForm>();
            services.AddTransient<MainPage>();
            services.AddTransient<MainPageLoggedIn>();
            services.AddTransient<CategoryTelevisors>();
            services.AddScoped<AdminPanelForm>();

            return services.BuildServiceProvider();
        }

    }
}
