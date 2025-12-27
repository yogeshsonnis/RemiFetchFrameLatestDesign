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

namespace RemiFetchFrame.Views.ExtractFromVMs
{
    /// <summary>
    /// Interaction logic for ExtractFromVMWizard3.xaml
    /// </summary>
    public partial class ExtractFromVMWizard3 : UserControl
    {
        public ExtractFromVMWizard3()
        {
            InitializeComponent();
            LoadMetrics();
        }

        private void LoadMetrics()
        {
            var metrics = new List<object>
            {
                new { Metric = "Total Backups Processed", Value = "3" },
                new { Metric = "Total Data Types Extracted", Value = "12" },
                new { Metric = "Successful Extractions", Value = "8" },
                new { Metric = "Partial Extractions", Value = "3" },
                new { Metric = "Failed / Missing", Value = "1" },
                new { Metric = "Total Job Size", Value = "42.6 GB" },
                new { Metric = "Total Extracted Size", Value = "31.2 GB" },
                new { Metric = "Average Extraction Rate", Value = "6.1 MB/s" },
                new { Metric = "Elapsed Time", Value = "00:18:52" },
                new { Metric = "Estimated Time Remaining", Value = "00:06:20" }
            };

            DataContext = metrics;
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
}
