using System;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PizzeriaNET.Client.Core.Services;
using PizzeriaNET.Client.WinForms.Forms;
using PizzeriaNET.Client.WinForms.Services;

namespace PizzeriaNET.Client.WinForms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (var serviceProvider = services.BuildServiceProvider())
            {
                var form = serviceProvider.GetRequiredService<MainForm>();
                Application.Run(form);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(AppContext.BaseDirectory).AddJsonFile("appsettings.json", false).Build();

            services.AddLogging(builder =>
            {
                builder.AddConfiguration(configuration.GetSection("Logging"));
                builder.AddConsole();
                builder.AddDebug();
            });

            services.Configure<CoreConfig>(configuration.GetSection(nameof(CoreConfig)));

            services.AddSingleton<MainForm>();
            services.AddScoped<IViewModelService, ViewModelService>();
            services.AddScoped<ICommunicationService, CommunicationService>(provider =>
                new CommunicationService(
                    provider.GetRequiredService<ILogger<CommunicationService>>(),
                    provider.GetRequiredService<IOptions<CoreConfig>>().Value.remoteAddress));
        }
    }
}
