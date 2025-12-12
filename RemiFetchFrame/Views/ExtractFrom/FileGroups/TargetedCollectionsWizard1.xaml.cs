using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace RemiFetchFrame.Views.ExtractFrom.FileGroups
{
    public partial class TargetedCollectionsWizard1 : Page
    {
        public TargetedCollectionsWizard1()
        {
            InitializeComponent();
        }

        private void ByFileGroup_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new FileGroupWizard2());
        }
    }
}
