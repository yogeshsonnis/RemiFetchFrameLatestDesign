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
using static Remi.Fetch.Views.Group.FileGroupWizard2;

namespace Remi.Fetch.Views.Group
{
    /// <summary>
    /// Interaction logic for FileGroupWizard2.xaml
    /// </summary>
    public partial class FileGroupWizard2 : UserControl
    {
        public ObservableCollection<CollectionItem> CollectionItems { get; set; }
        public FileGroupWizard2()
        {
            InitializeComponent();
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            var collectionData = new List<CollectionItem>
    {
        new CollectionItem
        {
            IsSelected = false,
            Filename = "document1.docx",
            Path = @"C:\Users\Example\Documents\",
            Category = "Documents",
            Size = "120 KB",
            Status = "Collected"
        },
        new CollectionItem
        {
            IsSelected = false,
            Filename = "image1.jpg",
            Path = @"C:\Users\Example\Pictures\",
            Category = "Media",
            Size = "450 KB",
            Status = "Pending"
        },
        new CollectionItem
        {
            IsSelected = false,
            Filename = "presentation.pptx",
            Path = @"C:\Users\Example\Documents\",
            Category = "Documents",
            Size = "2.1 MB",
            Status = "Collected"
        },
        new CollectionItem
        {
            IsSelected = false,
            Filename = "spreadsheet.xlsx",
            Path = @"C:\Users\Example\Documents\",
            Category = "Documents",
            Size = "980 KB",
            Status = "Collected"
        },
        new CollectionItem
        {
            IsSelected = false,
            Filename = "video_clip.mp4",
            Path = @"C:\Users\Example\Videos\",
            Category = "Media",
            Size = "15.6 MB",
            Status = "Pending"
        },
        new CollectionItem
        {
            IsSelected = false,
            Filename = "audio_note.mp3",
            Path = @"C:\Users\Example\Music\",
            Category = "Media",
            Size = "3.4 MB",
            Status = "Collected"
        }
    };

            CollectionItems = new ObservableCollection<CollectionItem>(collectionData);
            DataContext = this;
        }
        public class CollectionItem
        {
            public bool IsSelected { get; set; }   // 👈 checkbox
            public string Filename { get; set; }
            public string Path { get; set; }
            public string Category { get; set; }
            public string Size { get; set; }
            public string Status { get; set; }
        }
    }
}
