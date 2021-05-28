using System.Windows;
using Microsoft.Extensions.Configuration;

namespace WPF.NETGenericHost
{
    public partial class MainWindow : Window
    {
        public MainWindow(IConfiguration configuration)
        {
            InitializeComponent();

            TextBox.Text = configuration.GetSection("MainWindowText").Value;
        }
    }
}