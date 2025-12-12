using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace RemiFetchFrame.Views.TargetedCollections.IncidentResponse
{
    public partial class IncidentResponseWizard3 : Page
    {
        public IncidentResponseWizard3()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new IncidentResponseWizard2());
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
