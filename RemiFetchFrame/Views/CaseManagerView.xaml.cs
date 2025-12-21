using Microsoft.Win32;
using RemiFetchFrame.Models;
using RemiFetchFrame.Services;
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
        DatabaseService _db;
        public ObservableCollection<CaseModel> Cases { get; set; } = new();

        public CaseManagerView(/*AppShellFrame parent*/)
        {
            InitializeComponent();
            //_parent = parent;
            //_db = new DatabaseService();
            this.DataContext = this;
            _db = new DatabaseService();
            LoadCases();

        }
     
        private async void Add_Click(object sender, RoutedEventArgs e)
        {
            // Case Name validation
            if (string.IsNullOrWhiteSpace(casenameTextbox.Text))
            {
                MessageBox.Show("Please enter Case Name");
                casenameTextbox.Focus();
                return;
            }
            // Matter Number validation
            if (!int.TryParse(matterNumberTextbox.Text, out int matterNumber))
            {
                MessageBox.Show("Please enter a valid Matter Number");
                matterNumberTextbox.Focus();
                return;
            }

            // Examiner validation
            if (string.IsNullOrWhiteSpace(examinerTextbox.Text))
            {
                MessageBox.Show("Please enter Examiner Name");
                examinerTextbox.Focus();
                return;
            }
            var model = new CaseModel
            {
                CaseName = casenameTextbox.Text,
                MatterNumber = int.TryParse(matterNumberTextbox.Text, out int num) ? num : 0,
                Examiner = examinerTextbox.Text,
                SaveLocation = @"C:\Cases\Gamma",
                CreatedDate = DateTime.Now,
                TotalDevices = 3

            };

            await _db.AddCaseAsync(model);
            MessageBox.Show("Case Added");

            casenameTextbox.Text=string.Empty;
            matterNumberTextbox.Text = string.Empty;
            examinerTextbox.Text = string.Empty;
        }



        private async Task Load_Click()
        {
            var data = await _db.GetCasesAsync();
            Cases.Clear();

            foreach (var item in data)
            {
                Cases.Add(item);
            }
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
            AppShellFrame nextWin = new AppShellFrame(); // this must be Window
            nextWin.Show();  // Opens the new window

            this.Close();

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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void QuiteButtonChecked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void NewCase_Clicked(object sender, RoutedEventArgs e)
        {
            NewCaseView.Visibility = Visibility.Visible;
            OpenCaseView.Visibility = Visibility.Collapsed;

        }

        private void QuiteButton_Clicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void OpenCase_Clicked(object sender, RoutedEventArgs e)
        {
            NewCaseView.Visibility = Visibility.Collapsed;
            OpenCaseView.Visibility = Visibility.Visible;
            await Load_Click();
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
