using System.Windows;
using System.Windows.Controls;

namespace Remi.Fetch.Views.Extract_From_E01
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
            var data = new List<ImageInfo>
    {
        new ImageInfo { ImageSet="Case001.E01", SourcePath="D:/Evidence/Case001/", Size="8.4 GB", VolumeCount=3, Status="Imported"},
        new ImageInfo { ImageSet="Case002.E01", SourcePath="E:/Cases/Backup/", Size="9.1 GB", VolumeCount=2, Status="Pending"},
        new ImageInfo { ImageSet="Case003.E01", SourcePath="C:/Investigations/", Size="6.7 GB", VolumeCount=1, Status="Validated"}
    };

            MyDataGrid.ItemsSource = data;
        }

        //private void NextButton_Click(object sender, RoutedEventArgs e)
        //{
        //        var window = Window.GetWindow(this);

        //        var mainContent = window.FindName("MainContent") as ContentControl;

        //        mainContent.Content = new ExtractFromE012();
        //}


    }
    public class ImageInfo
    {
        public string ImageSet { get; set; }
        public string SourcePath { get; set; }
        public string Size { get; set; }
        public int VolumeCount { get; set; }
        public string Status { get; set; }
    }
}
