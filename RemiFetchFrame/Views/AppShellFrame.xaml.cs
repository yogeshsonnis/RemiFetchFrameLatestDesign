using System.Windows;

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

        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            CaseManagerView nextWin = new CaseManagerView(); // this must be Window
            nextWin.Show();  // Opens the new window

            this.Close();
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
