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

        //public ObservableCollection<CaseModel> Cases { get; set; } = new();

        public CaseManagerView(/*AppShellFrame parent*/)
        {
            InitializeComponent();
            //_parent = parent;
            //_db = new DatabaseService();
            //LoadCases();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //this.Content = new DataCollectionMenu();
            DataCollectionMenu nextWin = new DataCollectionMenu(); // this must be Window
            nextWin.Show();  // Opens the new window

            this.Close();    // Close current window (optional)
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
