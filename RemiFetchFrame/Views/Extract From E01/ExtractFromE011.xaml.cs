using System.Windows;
using System.Windows.Controls;

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

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
                var window = Window.GetWindow(this);

                var mainContent = window.FindName("MainContent") as ContentControl;

                mainContent.Content = new ExtractFromE012();
        }

        
    }
}
