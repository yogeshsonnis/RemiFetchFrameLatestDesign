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
using System.Windows.Shapes;

namespace Remi.Fetch.Views
{
    /// <summary>
    /// Interaction logic for DataCollectionsDashboardView.xaml
    /// </summary>
    public partial class DataCollectionsDashboardView : Window
    {
        public DataCollectionsDashboardView()
        {
            InitializeComponent();

            //// Load default landing page (optional)
            //ContentFrame.Navigate(new TargetedCollectionsWizard1());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ExtractFromItunesView nextWin = new ExtractFromItunesView(); // this must be Window
            nextWin.Show();  // Opens the new window

            this.Close();    // Close current window (optional)
        }

        //// Targeted Collections
        //private void TargetedCollections_Click(object sender, RoutedEventArgs e)
        //{
        //    ContentFrame.Navigate(new TargetedCollectionsWizard1());
        //}

        //// Extract From
        //private void ExtractFrom_Click(object sender, RoutedEventArgs e)
        //{
        //    ContentFrame.Navigate(new ExtractFromE01Wizard1());
        //}

        //// Preserve Devices
        //private void PreserveDevices_Click(object sender, RoutedEventArgs e)
        //{
        //    ContentFrame.Navigate(new PreserveByPathWizard1());
        //}

        //// Reports
        //private void Reports_Click(object sender, RoutedEventArgs e)
        //{
        //    ContentFrame.Navigate(new ReportsView());
        //}

        //// Case Overview
        //private void CaseOverview_Click(object sender, RoutedEventArgs e)
        //{
        //    ContentFrame.Navigate(new CaseInventoryView());
        //}

        //// Utility Buttons
        //private void Settings_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Settings dialog coming soon.", "Settings");
        //}

        //private void Help_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Help section placeholder.", "Help");
        //}

        //private void Logout_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Close();
        //}
    }
}
