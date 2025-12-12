using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace RemiFetchFrame.Views.ExtractFrom.iTunes
{
    public partial class iTunesWizard3 : Page
    {
        public iTunesWizard3()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new iTunesWizard2());
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
