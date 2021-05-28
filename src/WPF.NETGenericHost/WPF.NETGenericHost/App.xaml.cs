using System.Windows;
using Microsoft.Extensions.Hosting;


namespace WPF.NETGenericHost
{

    public partial class App : Application
    {
        private readonly IHost _host;

        public App()
        {
            _host = Host.CreateDefaultBuilder()
                .Build();
        }
    }
}