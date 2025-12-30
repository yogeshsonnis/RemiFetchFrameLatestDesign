using RemiFetchFrame.Views.Extract_From_E01;
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

namespace RemiFetchFrame.Views.ExtractFromVMs
{
    /// <summary>
    /// Interaction logic for ExtractFromVMWizard2.xaml
    /// </summary>
    public partial class ExtractFromVMWizard2 : UserControl
    {
        public ExtractFromVMWizard2()
        {
            InitializeComponent();
        }

        private void SelectAll_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Implement logic to check all boxes
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Implement logic to uncheck all boxes
        }

        private void OnNext(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);

            var mainContent = window.FindName("MainContent") as ContentControl;

            mainContent.Content = new ExtractFromVMWizard3();
        }
    }
}
