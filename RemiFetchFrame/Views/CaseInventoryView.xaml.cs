using System.Windows;
using System.Windows.Controls;

namespace Remi.Fetch.Views
{
    /// <summary>
    /// Interaction logic for CaseInventoryView.xaml
    /// </summary>
    public partial class CaseInventoryView : Window
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
            CaseManagerView nextWin = new CaseManagerView(); // this must be Window
            nextWin.Show();  // Opens the new window

            this.Close();    // Close current window (optional)

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
