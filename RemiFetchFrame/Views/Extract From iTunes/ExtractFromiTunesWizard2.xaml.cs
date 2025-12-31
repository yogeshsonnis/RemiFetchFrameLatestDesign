using Remi.Fetch.Views.Extract_From_E01;
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

namespace Remi.Fetch.Views.Extract_From_iTunes
{
    /// <summary>
    /// Interaction logic for ExtractFromiTunesWizard2.xaml
    /// </summary>
    public partial class ExtractFromiTunesWizard2 : UserControl
    {
        public ExtractFromiTunesWizard2()
        {
            InitializeComponent();
        }

        private void OnSelectAll(object sender, RoutedEventArgs e)
        {
            foreach (var cb in DataGroupList.Children.OfType<CheckBox>())
                cb.IsChecked = true;
        }

        private void OnClearAll(object sender, RoutedEventArgs e)
        {
            foreach (var cb in DataGroupList.Children.OfType<CheckBox>())
                cb.IsChecked = false;
        }

        //private void OnNext(object sender, RoutedEventArgs e)
        //{
        //    var window = Window.GetWindow(this);

        //    var mainContent = window.FindName("MainContent") as ContentControl;

            
        //    mainContent.Content = new ExtractFromiTunesWizard3();
        //}

        //private void OnNext(object sender, RoutedEventArgs e)
        //{
        //    var wizard3 = new ExtractFromiTunes_Wizard3();
        //    wizard3.Show();
        //    this.Close();
        //}
    }
}
