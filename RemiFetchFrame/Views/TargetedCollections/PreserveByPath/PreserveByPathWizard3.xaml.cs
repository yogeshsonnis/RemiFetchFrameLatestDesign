using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace RemiFetchFrame.Views.TargetedCollections.PreserveByPath
{
    public partial class PreserveByPathWizard3 : Page
    {
        public PreserveByPathWizard3()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new PreserveByPathWizard2());
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
