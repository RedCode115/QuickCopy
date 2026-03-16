using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Extensions.Configuration;

namespace UI
{
    /// <summary>
    /// Interaction logic for CopyWindow.xaml
    /// </summary>
    public partial class CopyWindow : Window
    {
        string connectionString;
        string databaseType;

        public CopyWindow()
        {
            InitializeComponent();
            LeesConfig();
        }

        private void LeesConfig()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var config = builder.Build();
            connectionString = config.GetConnectionString("SQLServerConnection");
            databaseType = config.GetSection("AppSettings")["databaseType"];
        }
    }
}