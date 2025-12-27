using RemiFetchFrame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RemiFetchFrame.Views
{
    /// <summary>
    /// Interaction logic for ModuleViewHost.xaml
    /// </summary>
    public partial class ModuleViewHost : UserControl
    {
        public ModuleViewHost()
        {
            InitializeComponent();
            ModuleRegistrationService.LoadModules();
            Sidebar.ItemsSource = ModuleRegistrationService.Modules;
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Sidebar.SelectedItem is not ModuleInfo module)
                return;

            // Create and load the view
            var view = ModuleRegistrationService.CreateViewInstance(module.View);
            if (view != null)
            {
                ContentHost.Content = view;
            }
            else
            {
                MessageBox.Show(
                    $"Could not load view for module:\n\n{module.View}",
                    "Module Load Error",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                );
            }
        }
    }
}
