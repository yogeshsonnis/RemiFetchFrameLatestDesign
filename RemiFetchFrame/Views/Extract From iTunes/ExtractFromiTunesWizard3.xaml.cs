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

namespace RemiFetchFrame.Views.Extract_From_iTunes
{
    /// <summary>
    /// Interaction logic for ExtractFromiTunesWizard3.xaml
    /// </summary>
    public partial class ExtractFromiTunesWizard3 : UserControl
    {
        public ExtractFromiTunesWizard3()
        {
            InitializeComponent();
        }

        private void OnStart(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("iTunes data extraction started (static preview).", "Collect & Export");
        }

        private void OnFinish(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("iTunes data extraction completed successfully.", "Export Finished");
            //this.Close();
        }
    }
}
