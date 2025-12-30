using Microsoft.Win32;
using RemiFetchFrame.Views.Extract_From_E01;
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

namespace RemiFetchFrame.Views.Extract_From_iTunes
{
    /// <summary>
    /// Interaction logic for ExtractFromiTunesWizard1.xaml
    /// </summary>
    public partial class ExtractFromiTunesWizard1 : UserControl
    {
        public ObservableCollection<BackupItem> Backups { get; set; }
        public ExtractFromiTunesWizard1()
        {
            InitializeComponent();
            Backups = new ObservableCollection<BackupItem>();
            BackupList.ItemsSource = Backups;
        }

        private void OnAddFolder(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                CheckFileExists = false,
                FileName = "Select Folder"
            };

            if (dialog.ShowDialog() == true)
            {
                var folderPath = System.IO.Path.GetDirectoryName(dialog.FileName);

                Backups.Add(new BackupItem
                {
                    Name = System.IO.Path.GetFileName(folderPath),
                    Path = folderPath,
                    Size = "—",
                    Status = "Pending"
                });
            }
        }

        private void OnRemoveSelected(object sender, RoutedEventArgs e)
        {
            if (BackupList.SelectedItem is BackupItem selected)
            {
                Backups.Remove(selected);
            }
        }

        private void OnClearList(object sender, RoutedEventArgs e)
        {
            Backups.Clear();
        }

        private void OnNext(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);

            var mainContent = window.FindName("MainContent") as ContentControl;

            
            mainContent.Content = new ExtractFromiTunesWizard2();
        }



        //private void OnNext(object sender, RoutedEventArgs e)
        //{
        //    var wizard2 = new ExtractFromiTunes_Wizard2();
        //    wizard2.Show();
        //    //this.Close();
        //}
    }

    public class BackupItem
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Size { get; set; }
        public string Status { get; set; }
    }
}
