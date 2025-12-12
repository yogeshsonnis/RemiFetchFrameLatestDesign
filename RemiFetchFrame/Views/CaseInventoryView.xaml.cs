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

namespace RemiFetchFrame.Views
{
    /// <summary>
    /// Interaction logic for CaseInventoryView.xaml
    /// </summary>
    public partial class CaseInventoryView : Page
    {
        //private readonly AppShellFrame _parent;
        //private readonly DatabaseService _db;
        //public ObservableCollection<EvidenceModel> Inventory { get; set; } = new();
        //public CaseModel CurrentCase { get; }

        public CaseInventoryView(/*AppShellFrame parent, CaseModel caseModel*/)
        {
            InitializeComponent();
            //_parent = parent;
            //_db = new DatabaseService();
            //CurrentCase = caseModel;
            //DataContext = caseModel;
            //LoadInventory();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new CaseManagerView();
        }

        //private void LoadInventory()
        //{
        //    Inventory.Clear();
        //    foreach (var ev in _db.GetEvidenceByCase(CurrentCase.Id))
        //        Inventory.Add(ev);

        //    InventoryList.ItemsSource = Inventory;
        //}

        //private void BtnAddEvidence_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Evidence import dialog not yet implemented.", "Fetch & Retrieve");
        //}

        //private void BtnBack_Click(object sender, RoutedEventArgs e)
        //{
        //    _parent.ReturnToManager();
        //}

        //private void CollectMoreData_Click(object sender, RoutedEventArgs e)
        //{
        //    // Launch the full forensic data collection dashboard
        //    var dashboard = new DataCollectionsDashboardView
        //    {
        //        Owner = Application.Current.MainWindow,
        //        WindowStartupLocation = WindowStartupLocation.CenterOwner
        //    };

        //    // Open the full dashboard in modal mode
        //    dashboard.ShowDialog();
        //}
    }
}
