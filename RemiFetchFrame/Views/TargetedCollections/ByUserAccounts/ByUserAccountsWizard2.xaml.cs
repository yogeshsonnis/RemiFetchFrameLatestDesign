using RemiFetchFrame.Views.ExtractFrom.FileGroups;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace RemiFetchFrame.Views.TargetedCollections.ByUserAccounts
{
    public partial class ByUserAccountsWizard2 : Page
    {
        public ByUserAccountsWizard2()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new TargetedCollectionsWizard1());
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new ByUserAccountsWizard3());
        }
    }
}
