using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace RemiFetchFrame.Views.ExtractFrom.VM
{
    public partial class VMWizard1 : Page
    {
        public VMWizard1()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new VMWizard2());
        }
    }
}
