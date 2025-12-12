using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace RemiFetchFrame.Views.TargetedCollections.Communications
{
    public partial class CommunicationsWizard3 : Page
    {
        public CommunicationsWizard3()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new CommunicationsWizard2());
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
