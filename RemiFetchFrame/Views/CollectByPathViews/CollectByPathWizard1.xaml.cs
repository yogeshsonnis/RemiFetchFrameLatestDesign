using Remi.Fetch.Views.Extract_From_E01;
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
using System.Xml.XPath;

namespace Remi.Fetch.Views.CollectByPathViews
{
    /// <summary>
    /// Interaction logic for CollectByPathWizard1.xaml
    /// </summary>
    public partial class CollectByPathWizard1 : UserControl
    {
        public ObservableCollection<PathItem> Paths { get; set; }
        public ObservableCollection<PathValidation> Validations { get; set; }
        public CollectByPathWizard1()
        {
            InitializeComponent();
            Paths = new ObservableCollection<PathItem>
            {
                new PathItem { Path = "C:/Users/Admin/Documents/" },
                new PathItem { Path = "D:/CaseEvidence/Logs/" }
            };
            Validations = new ObservableCollection<PathValidation>();

            PathsGrid.ItemsSource = Paths;
            ValidationGrid.ItemsSource = Validations;
        }

        private void OnAddPath(object sender, RoutedEventArgs e)
        {
            Paths.Add(new PathItem { Path = "New Path..." });
        }

        private void OnRemovePath(object sender, RoutedEventArgs e)
        {
            if (PathsGrid.SelectedItem is PathItem selected)
                Paths.Remove(selected);
        }

        private void OnBrowse(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("File browser placeholder.", "Browse");
        }

        private void OnValidate(object sender, RoutedEventArgs e)
        {
            Validations.Clear();
            Validations.Add(new PathValidation
            {
                Path = "C:/Users/Admin/Documents/",
                Status = "Valid",
                Permissions = "Read/Write",
                Type = "Folder",
                Owner = "Admin",
                LastModified = "2024-09-12"
            });
            Validations.Add(new PathValidation
            {
                Path = "D:/CaseEvidence/Logs/",
                Status = "Not Found",
                Permissions = "None",
                Type = "Folder",
                Owner = "Investigator",
                LastModified = "—"
            });
        }

        //private void NextButton_Click(object sender, RoutedEventArgs e)
        //{
        //    var window = Window.GetWindow(this);

        //    var mainContent = window.FindName("MainContent") as ContentControl;

        //    mainContent.Content = new CollectByPathWizard2();
        //}

        //private void OnNext(object sender, RoutedEventArgs e)
        //{
        //    var wizard2 = new CollectByPathWizard2();
        //    wizard2.Show();
        //    //this.Close();
        //}
    }

    public class PathItem
    {
        public string Path { get; set; }
    }

    public class PathValidation
    {
        public string Path { get; set; }
        public string Status { get; set; }
        public string Permissions { get; set; }
        public string Type { get; set; }
        public string Owner { get; set; }
        public string LastModified { get; set; }
    }
}
