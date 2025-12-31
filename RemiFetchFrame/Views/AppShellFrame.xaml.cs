using Remi.Fetch.Views.Extract_From_E01;
using Remi.Fetch.Views.Extract_From_iTunes;
using System.Windows;
using System.Windows.Controls;

namespace Remi.Fetch.Views
{
    /// <summary>
    /// Interaction logic for AppShellFrame.xaml
    /// </summary>
    public partial class AppShellFrame : Window
    {
        public AppShellFrame()
        {
            InitializeComponent();

            
           

            //  ResizeMode = ResizeMode.CanMinimize; // Disable maximizing and resizing
            double differenceX = SystemParameters.MaximizedPrimaryScreenWidth - SystemParameters.WorkArea.Width;
            double differenceY = SystemParameters.MaximizedPrimaryScreenHeight - SystemParameters.WorkArea.Height;
            Left = -differenceX / 2;
            Top = 0;
            Width = SystemParameters.MaximizedPrimaryScreenWidth > 1200 ? 1100 : 960;
            Height = (SystemParameters.MaximizedPrimaryScreenHeight - differenceY / 2) > 1000 ? 900 : 850;

            //MainFrame.Navigate(new ExtractFromE011(this)); // start example
        }

        int currentStep = 0;
        string currentType = "";

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentStep == 1)
            {
                if (currentType == "iTunes")
                    MainContent.Content = new Remi.Fetch.Views.Extract_From_iTunes.ExtractFromiTunesWizard2();

                else if (currentType == "VMs")
                    MainContent.Content = new Remi.Fetch.Views.ExtractFromVMs.ExtractFromVMWizard2();

                else if (currentType == "E01")
                    MainContent.Content = new Remi.Fetch.Views.Extract_From_E01.ExtractFromE012();

                else if (currentType == "Path")
                    MainContent.Content = new Remi.Fetch.Views.CollectByPathViews.CollectByPathWizard2();

                else if (currentType == "Group")
                    MainContent.Content = new Remi.Fetch.Views.Group.FileGroupWizard2();

                currentStep = 2; 
            }

           
            else if (currentStep == 2)
            {
                
                if (currentType == "iTunes")
                {
                    MainContent.Content = new Remi.Fetch.Views.Extract_From_iTunes.ExtractFromiTunesWizard3();
                    currentStep = 3;
                }
                else if (currentType == "VMs")
                {
                    MainContent.Content = new Remi.Fetch.Views.ExtractFromVMs.ExtractFromVMWizard3();
                    currentStep = 3;
                }
                else if (currentType == "E01")
                {
                    MainContent.Content = new Remi.Fetch.Views.Extract_From_E01.ExtractFromE013();
                    currentStep = 3;
                }

                
            }

        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            CaseManagerView nextWin = new CaseManagerView(); // this must be Window
            nextWin.Show();  // Opens the new window

            this.Close();
        }

        private void FromE01_Click(object sender, RoutedEventArgs e)
        {
            currentType = "E01";
            currentStep = 1;

            MainContent.Content =
        new Remi.Fetch.Views.Extract_From_E01.ExtractFromE011();
        }

        private void FromiTunes_Click(object sender, RoutedEventArgs e)
        {
            currentType = "iTunes";
            currentStep = 1;

            MainContent.Content =
        new Remi.Fetch.Views.Extract_From_iTunes.ExtractFromiTunesWizard1();
        }

        private void FromiVMs_Click(object sender, RoutedEventArgs e)
        {
            currentType = "VMs";
            currentStep = 1;
            MainContent.Content =
        new Remi.Fetch.Views.ExtractFromVMs.ExtractFromVMWizard1();
        }

        private void ByFileGroup_Click(object sender, RoutedEventArgs e)
        {
            currentType = "Group";
            currentStep = 1;

            MainContent.Content =
        new Remi.Fetch.Views.Group.FileGroupWizard1();
        }

        private void ByPath_Click(object sender, RoutedEventArgs e)
        {
            currentType = "Path"; // "Path" type set kiya
            currentStep = 1;

            MainContent.Content =
       new Remi.Fetch.Views.CollectByPathViews.CollectByPathWizard1();
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
