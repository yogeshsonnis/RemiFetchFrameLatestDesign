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

namespace RemiFetchFrame.Views.Group
{
    /// <summary>
    /// Interaction logic for FileGroupWizard2.xaml
    /// </summary>
    public partial class FileGroupWizard2 : UserControl
    {
        public FileGroupWizard2()
        {
            InitializeComponent();
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            var collectionData = new List<object>
            {
                new { Filename = "document1.docx", Path = @"C:\Users\Example\Documents\", Category = "Documents", Size = "120 KB", Status = "Collected" },
                new { Filename = "image1.jpg", Path = @"C:\Users\Example\Pictures\", Category = "Media", Size = "450 KB", Status = "Pending" }
            };

            DataContext = collectionData;
        }
    }
}
