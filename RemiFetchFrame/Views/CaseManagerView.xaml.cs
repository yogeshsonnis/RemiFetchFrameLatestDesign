using Microsoft.Win32;
using RemiFetchFrame.Models;
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
    /// Interaction logic for CaseManagerView.xaml
    /// </summary>
    public partial class CaseManagerView : Window
    {
        //private readonly AppShellFrame _parent;
        //private readonly DatabaseService _db;

        public ObservableCollection<CaseModel> Cases { get; set; } = new();

        public CaseManagerView(/*AppShellFrame parent*/)
        {
            InitializeComponent();
            //_parent = parent;
            //_db = new DatabaseService();
            this.DataContext = this;
            LoadCases();
            NewCaseRadioButton.IsChecked = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //this.Content = new DataCollectionMenu();
            DataCollectionMenu nextWin = new DataCollectionMenu(); // this must be Window
            nextWin.Show();  // Opens the new window

            this.Close();    // Close current window (optional)
        }

        private void LoadCases()
        {

            // Seed data (optional)
            Cases.Add(new CaseModel
            {
                CaseName = "Case Alpha",
                MatterNumber = 1234,
                SaveLocation = @"C:\Cases\Alpha",
                CreatedDate = new DateTime(2025, 10, 05),
                TotalDevices = 4
            });
            Cases.Add(new CaseModel
            {
                CaseName = "Case Beta",
                MatterNumber = 5678,
                SaveLocation = @"C:\Cases\Beta",
                CreatedDate = new DateTime(2025, 09, 20),
                TotalDevices = 7
            });
            Cases.Add(new CaseModel
            {
                CaseName = "Case Gamma",
                MatterNumber = 9012,
                SaveLocation = @"C:\Cases\Gamma",
                CreatedDate = new DateTime(2025, 08, 15),
                TotalDevices = 3
            });


        }

        private void NewCaseRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            NewCaseView.Visibility = Visibility.Visible;
            OpenCaseView.Visibility = Visibility.Collapsed;
        }

        private void Open_CaseRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            NewCaseView.Visibility = Visibility.Collapsed;
            OpenCaseView.Visibility = Visibility.Visible;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ((DataGrid)sender).SelectedIndex = -1;
        }

        private void ChooseFile(object sender, RoutedEventArgs e)
        {


            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select a file";
            dialog.Filter = "All Files (*.*)|*.*"; // optional filter

            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                string filePath = dialog.FileName;

                // show selected file path
                MessageBox.Show("Selected File:\n" + filePath);

                // TODO: use filePath however you want
            }

        }

        //private void LoadCases()
        //{
        //    Cases.Clear();
        //    foreach (var c in _db.GetAllCases())
        //        Cases.Add(c);
        //    CaseListView.ItemsSource = Cases;
        //}

        //private void BtnNewCase_Click(object sender, RoutedEventArgs e)
        //{
        //    var dialog = new NewCaseDialog();
        //    if (dialog.ShowDialog() == true)
        //    {
        //        var caseName = dialog.CaseName;
        //        var caseFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Cases", caseName);
        //        Directory.CreateDirectory(caseFolder);

        //        var newCase = new CaseModel
        //        {
        //            CaseName = caseName,
        //            FolderPath = caseFolder,
        //            CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
        //        };

        //        _db.AddCase(newCase);
        //        LoadCases();
        //    }
        //}

        //private void BtnOpenCase_Click(object sender, RoutedEventArgs e)
        //{
        //    if (CaseListView.SelectedItem is CaseModel selected)
        //        _parent.OpenCase(selected);
        //}

        //private void CaseListView_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        //{
        //    if (CaseListView.SelectedItem is CaseModel selected)
        //        _parent.OpenCase(selected);
        //}
    }
}

