using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace RemiFetchFrame.Views.ExtractFrom.iTunes
{
    public partial class iTunesWizard1 : Page
    {
        public iTunesWizard1()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new iTunesWizard2());
        }
    }
}
