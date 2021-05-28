using System.Windows;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace WPF.NETGenericHost
{

    public partial class App : Application
    {
        private readonly IHost _host;

        public App()
        {
            _host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => MyAppConfigureServices(context.Configuration, services))
                .Build();
        }

        private void MyAppConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddTransient<MainWindow>();
        }

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            _host.Services.GetRequiredService<MainWindow>().Show();
        }
    }
}