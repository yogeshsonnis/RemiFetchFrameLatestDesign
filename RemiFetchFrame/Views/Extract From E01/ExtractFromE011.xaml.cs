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

namespace RemiFetchFrame.Views.Extract_From_E01
{
    /// <summary>
    /// Interaction logic for ExtractFromE011.xaml
    /// </summary>
    public partial class ExtractFromE011 : UserControl
    {
        public ExtractFromE011()
        {
            InitializeComponent();
            LoadSampleData();
        }
        private void LoadSampleData()
        {
            var data = new[]
            {
                new { ImageSet = "Case001.E01", SourcePath = "D:/Evidence/Case001/", Size = "8.4 GB", VolumeCount = 3, Status = "Imported" },
                new { ImageSet = "Case002.E01", SourcePath = "E:/Cases/Backup/", Size = "9.1 GB", VolumeCount = 2, Status = "Pending" },
                new { ImageSet = "Case003.E01", SourcePath = "C:/Investigations/", Size = "6.7 GB", VolumeCount = 1, Status = "Validated" }
            };
            DataContext = data;
        }
    }
}
