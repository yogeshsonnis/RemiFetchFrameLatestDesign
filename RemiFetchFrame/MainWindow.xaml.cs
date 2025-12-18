using RemiFetchFrame.Views;
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

namespace RemiFetchFrame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public string LicenseSummary { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            //LoadLicenseInfo();
            Loaded += AppSplashScreen_Loaded;
        }

        //private void LoadLicenseInfo()
        //{
        //    var license = LicenseInfo.Load();
        //    LicenseSummary = $"{license.LicenseNumber} | {license.DongleId} | Expires {license.Expires}";
        //}

        private async void AppSplashScreen_Loaded(object sender, RoutedEventArgs e)
        {
            await Task.Delay(2000); // simulate loading time
            var shell = new CaseManagerView();
            shell.Show();
            Close();
        }
    }
}
