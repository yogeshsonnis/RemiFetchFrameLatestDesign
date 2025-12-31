using Remi.Fetch.Views.Extract_From_E01;
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

namespace Remi.Fetch.Views.ExtractFromVMs
{
    /// <summary>
    /// Interaction logic for ExtractFromVMWizard1.xaml
    /// </summary>
    public partial class ExtractFromVMWizard1 : UserControl
    {
        public ExtractFromVMWizard1()
        {
            InitializeComponent();
            LoadSources();
        }

        private void LoadSources()
        {
            var data = new List<object>
            {
                new { Filename = "VM_001.vmdk", SourcePath = @"D:\VirtualMachines\CaseA\", Size = "8.2 GB", VolumeCount = "3", Status = "Imported" },
                new { Filename = "VM_002.vhdx", SourcePath = @"E:\Evidence\VMs\", Size = "9.4 GB", VolumeCount = "2", Status = "Pending" },
                new { Filename = "VM_003.vhd", SourcePath = @"C:\Investigations\", Size = "6.7 GB", VolumeCount = "1", Status = "Validated" }
            };

            DataContext = data;
        }

        private void OnNext(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);

            var mainContent = window.FindName("MainContent") as ContentControl;

            mainContent.Content = new ExtractFromVMWizard2();
        }
    }
}
