using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace RemiFetchFrame.Views.ExtractFrom.FileGroups
{
    public partial class FileGroupWizard3 : Page
    {
        public FileGroupWizard3()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new FileGroupWizard2());
        }

        private void Finish_Click(object sender, RoutedEventArgs e)
        {
            // Return to dashboard or clear content frame
            if (NavigationService.CanGoBack)
            {
                while (NavigationService.CanGoBack)
                    NavigationService.GoBack();
            }
        }
    }
}
