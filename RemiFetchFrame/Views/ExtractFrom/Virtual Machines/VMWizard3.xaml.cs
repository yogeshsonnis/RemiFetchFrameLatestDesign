using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace RemiFetchFrame.Views.ExtractFrom.VM
{
    public partial class VMWizard3 : Page
    {
        public VMWizard3()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new VMWizard2());
        }

        private void Finish_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                while (NavigationService.CanGoBack)
                    NavigationService.GoBack();
            }
        }
    }
}
