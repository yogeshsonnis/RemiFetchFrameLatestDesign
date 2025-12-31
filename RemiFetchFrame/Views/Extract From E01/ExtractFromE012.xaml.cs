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

namespace Remi.Fetch.Views.Extract_From_E01
{
    /// <summary>
    /// Interaction logic for ExtractFromE012.xaml
    /// </summary>
    public partial class ExtractFromE012 : UserControl
    {
        public ExtractFromE012()
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

        private void OnNext(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);

            var mainContent = window.FindName("MainContent") as ContentControl;

            
            mainContent.Content = new ExtractFromE013();
        }
    }
}
