using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace RemiFetchFrame.Views.TargetedCollections.IncidentResponse
{
    public partial class IncidentResponseWizard2 : Page
    {
        public IncidentResponseWizard2()
        {
            InitializeComponent();
        }

        private void Discover_Click(object sender, RoutedEventArgs e)
        {
            // Placeholder for discovery logic
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
           // NavigationService?.Navigate(new TargetedCollectionsWizard1());
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new IncidentResponseWizard3());
        }
    }
}
