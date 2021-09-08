using LaMetricController.Services;
using LaMetricController.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace LaMetricController
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = CreateServices();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = services.GetRequiredService<MainForm>();
            services.GetRequiredService<ConfigurationService>().Load();
            Application.Run(form);
        }

        static IServiceProvider CreateServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<ConfigurationService>();
            services.AddSingleton<MessageService>();
            services.AddSingleton<MainForm>();
            return services.BuildServiceProvider();
        }
    }
}
