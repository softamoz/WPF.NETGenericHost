using System.Windows;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WPF.NETGenericHost
{
    public partial class MainWindow : Window
    {
        public MainWindow(IConfiguration configuration, ILogger<MainWindow> logger)
        {
            InitializeComponent();

            TextBox.Text = configuration.GetSection("MainWindowText").Value;

            logger.LogCritical($"{nameof(MainWindow)} is Loaded!!!!");
        }
    }
}