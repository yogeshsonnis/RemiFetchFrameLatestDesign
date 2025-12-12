using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RemiFetchFrame.Views
{
    /// <summary>
    /// Interaction logic for DataCollectionMenu.xaml
    /// </summary>
    public partial class DataCollectionMenu : Window
    {
        public DataCollectionMenu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataCollectionsDashboardView nextWin = new DataCollectionsDashboardView(); // this must be Window
            nextWin.Show();  // Opens the new window

            this.Close();    // Close current window (optional)
        }

        private void BtnItunes_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void BtnItunes_Click(object sender, RoutedEventArgs e)
        //{
        //    // navigate to iTunes extraction view
        //    var parent = Window.GetWindow(this) as AppShellFrame;
        //    parent?.MainFrame.Navigate(new ExtractFromItunesView());
        //}

        //private void BtnReports_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Reports module coming soon.", "Fetch & Retrieve");
        //}

        //private void BtnExport_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Export functionality under construction.", "Fetch & Retrieve");
        //}

        //private void BtnSettings_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Settings panel not yet implemented.", "Fetch & Retrieve");
        //}
    }
}
