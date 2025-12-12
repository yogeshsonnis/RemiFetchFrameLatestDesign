using RemiFetchFrame.Views.ExtractFrom.FileGroups;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace RemiFetchFrame.Views.TargetedCollections.Communications
{
    public partial class CommunicationsWizard2 : Page
    {
        public CommunicationsWizard2()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new TargetedCollectionsWizard1());
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new CommunicationsWizard3());
        }
    }
}
