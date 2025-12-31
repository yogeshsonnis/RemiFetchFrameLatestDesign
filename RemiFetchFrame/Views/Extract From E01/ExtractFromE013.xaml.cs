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

namespace Remi.Fetch.Views.Extract_From_E01
{
    /// <summary>
    /// Interaction logic for ExtractFromE013.xaml
    /// </summary>
    public partial class ExtractFromE013 : UserControl
    {
        public ExtractFromE013()
        {
            InitializeComponent();
        }

        private void OnStart(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Export process initiated (static preview).", "Collect & Export");
        }
    }
}
