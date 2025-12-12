using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace RemiFetchFrame.Views.ExtractFrom.VM
{
    public partial class VMWizard2 : Page
    {
        public VMWizard2()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new VMWizard1());
        }

        private void Next_Click(object sender, RoutedEventArgs e)


        {
            NavigationService?.Navigate(new VMWizard3());
        }
    }
}
