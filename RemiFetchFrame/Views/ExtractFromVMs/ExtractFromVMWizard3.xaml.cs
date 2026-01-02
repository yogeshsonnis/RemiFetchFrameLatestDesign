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
    /// Interaction logic for ExtractFromVMWizard3.xaml
    /// </summary>
    public partial class ExtractFromVMWizard3 : UserControl
    {
        public ExtractFromVMWizard3()
        {
            InitializeComponent();
            LoadExtractions();
        }

        private void LoadExtractions()
        {
            var extractions = new List<ExtractionItem>
        {
            new ExtractionItem
            {
                FilePath = @"D:\VirtualMachines\CaseA\VM_001.vmdk",
                Status = "Completed",
                Progress = "100%",
                Destination = @"E:\Extracted\VM_001\"
            },
            new ExtractionItem
            {
                FilePath = @"E:\Evidence\VMs\VM_002.vhdx",
                Status = "In Progress",
                Progress = "65%",
                Destination = @"E:\Extracted\VM_002\"
            },
            new ExtractionItem
            {
                FilePath = @"C:\Investigations\VM_003.vhd",
                Status = "Pending",
                Progress = "0%",
                Destination = @"E:\Extracted\VM_003\"
            }
        };

            DataContext = extractions; // ✅ Matches DataGrid
        }

        private void OnBack(object sender, RoutedEventArgs e)
        {

        }

        private void OnCancel(object sender, RoutedEventArgs e)
        {

        }

        private void OnFinish(object sender, RoutedEventArgs e)
        {

        }

        private void OnPause(object sender, RoutedEventArgs e)
        {

        }

        private void OnStartExtraction(object sender, RoutedEventArgs e)
        {

        }
    }
    public class ExtractionItem
    {
        public string FilePath { get; set; }
        public string Status { get; set; }
        public string Progress { get; set; }
        public string Destination { get; set; }
    }
}
