using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace RemiFetchFrame.Views.ExtractFrom.iTunes
{
    public partial class iTunesWizard2 : Page
    {
        public iTunesWizard2()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new iTunesWizard1());
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new iTunesWizard3());
        }
    }
}
