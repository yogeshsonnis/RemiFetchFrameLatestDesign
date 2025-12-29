using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace RemiFetchFrame.Views.CollectByPathViews
{
    /// <summary>
    /// Interaction logic for CollectByPathWizard2.xaml
    /// </summary>
    public partial class CollectByPathWizard2 : UserControl
    {
        public ObservableCollection<ExportTask> Exports { get; set; }
        public CollectByPathWizard2()
        {
            InitializeComponent();
            Exports = new ObservableCollection<ExportTask>
            {
                new ExportTask { Path="C:/Users/Admin/Documents/", Status="Completed", Progress="100%", Output="Admin_Documents.zip" },
                new ExportTask { Path="D:/CaseEvidence/Logs/", Status="Processing", Progress="60%", Output="Case_Logs.zip" },
                new ExportTask { Path="E:/Extra/Data/", Status="Queued", Progress="0%", Output="Extra_Data.zip" }
            };
            ExportGrid.ItemsSource = Exports;
        }

        private void OnStartExport(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Path collection and export started (static preview).", "Collect & Export");
        }

        private void OnFinish(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Export completed successfully.", "Finished");
            //this.Close();
        }
    }
    public class ExportTask
    {
        public string Path { get; set; }
        public string Status { get; set; }
        public string Progress { get; set; }
        public string Output { get; set; }
    }
}
