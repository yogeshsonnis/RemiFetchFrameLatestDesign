using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace RemiFetchFrame.Views.ExtractFrom.FileGroups
{
    public partial class FileGroupWizard2 : Page
    {
        public FileGroupWizard2()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new TargetedCollectionsWizard1());
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new FileGroupWizard3());
        }
    }
}
