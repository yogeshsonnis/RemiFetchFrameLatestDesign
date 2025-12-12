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
using System.Windows.Shapes;

namespace RemiFetchFrame.Views
{
    /// <summary>
    /// Interaction logic for AppShellFrame.xaml
    /// </summary>
    public partial class AppShellFrame : Window
    {
        public AppShellFrame()
        {
            InitializeComponent();
            //MainFrame.Navigate(new ExtractFromE01Wizard1(this)); // start example
        }
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            CaseInventoryView nextWin = new CaseInventoryView(); // this must be Window
            nextWin.Show();  // Opens the new window

            this.Close();    // Close current window (optional)
        }
        //    private void BtnNext_Click(object sender, RoutedEventArgs e)
        //    {
        //        if (MainFrame.Content is IWizardPage wiz) wiz.OnNext();
        //    }

        //    private void BtnBack_Click(object sender, RoutedEventArgs e)
        //    {
        //        if (MainFrame.Content is IWizardPage wiz) wiz.OnBack();
        //    }

        //    private void BtnCancel_Click(object sender, RoutedEventArgs e)
        //    {
        //        if (MainFrame.Content is IWizardPage wiz) wiz.OnCancel();
        //    }

        //    private void Quit_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        //    {
        //        Close();
        //    }
        //}

        //// Interface so every wizard page can react to shared buttons
        //public interface IWizardPage
        //{
        //    void OnNext();
        //    void OnBack();
        //    void OnCancel();
        //}
    }
}
