using RemiFetchFrame.Views.ExtractFrom.FileGroups;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace RemiFetchFrame.Views.TargetedCollections.DragAndDrop
{
    public partial class DragAndDropWizard2 : Page
    {
        public DragAndDropWizard2()
        {
            InitializeComponent();
        }

        private void DragEnter_Handler(object sender, DragEventArgs e)
        {
            e.Effects = DragDropEffects.Copy;
        }

        private void Drop_Handler(object sender, DragEventArgs e)
        {
            // Placeholder for file processing logic
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new TargetedCollectionsWizard1());
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new DragAndDropWizard3());
        }
    }
}
