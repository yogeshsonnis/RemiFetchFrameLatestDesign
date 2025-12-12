using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace RemiFetchFrame.Views
{
    /// <summary>
    /// Interaction logic for ExtractFromItunesView.xaml
    /// </summary>
    public partial class ExtractFromItunesView : Page
    {
        private readonly AppShellFrame _parentShell;
        private readonly string _caseName = "Case001";
        private readonly string _matterNumber = "2025-INV-001";
        private readonly ObservableCollection<BackupItem> _backups;

        public ExtractFromItunesView(AppShellFrame parentShell)
        {
            InitializeComponent();
            _parentShell = parentShell;
            _backups = new ObservableCollection<BackupItem>();
            BackupGrid.ItemsSource = _backups;
        }

        private async void ImportBtn_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Title = "Select iTunes Backup File",
                Filter = "iTunes Backups (*.zip;*.itb)|*.zip;*.itb|All Files (*.*)|*.*",
                Multiselect = true
            };

            if (dialog.ShowDialog() == true)
            {
                foreach (string filePath in dialog.FileNames)
                {
                    var fileInfo = new FileInfo(filePath);
                    var backup = new BackupItem
                    {
                        FilePath = filePath,
                        FileName = fileInfo.Name,
                        FileSizeMB = (fileInfo.Length / 1024d / 1024d).ToString("F2"),
                        Status = "Pending"
                    };

                    _backups.Add(backup);
                    ExportBtn.IsEnabled = true;

                    // Run processing for each backup asynchronously
                    await ProcessBackupAsync(backup);
                }
            }
        }

        private async Task ProcessBackupAsync(BackupItem backup)
        {
            try
            {
                backup.Status = "Processing...";
                LocalStatusText.Text = $"Processing {backup.FileName}";
                LocalProgressBar.Visibility = Visibility.Visible;
                LocalProgressBar.Value = 0;

                //var extractor = new ItunesBackupExtractor(_parentShell, _caseName, _matterNumber);

                //await extractor.ProcessBackupAsync(backup.FilePath);

                backup.Status = "Completed";
                LocalStatusText.Text = $"Completed: {backup.FileName}";
                LocalProgressBar.Value = 100;
                await Task.Delay(500);
                LocalProgressBar.Visibility = Visibility.Collapsed;
            }
            catch (Exception ex)
            {
                backup.Status = $"Error: {ex.Message}";
                LocalStatusText.Text = $"Error with {backup.FileName}";
                LocalProgressBar.Visibility = Visibility.Collapsed;
            }
        }

        private async void ExportBtn_Click(object sender, RoutedEventArgs e)
        {
            LocalStatusText.Text = "Packaging all exports...";
            LocalProgressBar.Visibility = Visibility.Visible;
            LocalProgressBar.Value = 0;

            // Simulate combined export
            for (int i = 0; i <= 100; i += 10)
            {
                LocalProgressBar.Value = i;
                await Task.Delay(100);
            }

            LocalStatusText.Text = "All exports completed.";
            LocalProgressBar.Visibility = Visibility.Collapsed;
            //_parentShell.UpdateStatus("All iTunes exports finalized.", -1);
        }
    }

    public class BackupItem
    {
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public string FileSizeMB { get; set; }
        public string FileHash { get; set; }
        public string Status { get; set; }
    }
}
