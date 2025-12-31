using Remi.Fetch.Views;
using SQLitePCL;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Navigation;

namespace Remi.Fetch
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Batteries.Init();
        }
        //protected override async void OnStartup(StartupEventArgs e)
        //{
        //    base.OnStartup(e);

        //    // 1️⃣ Show splash
        //    var splash = new SplashScreen();
        //    splash.Show();

        //    try
        //    {
        //        // 2️⃣ Initialize backend systems
        //        await Task.Run(() => AppInitializer.Initialize());

        //        splash.Dispatcher.Invoke(() =>
        //        {
        //            splash.StatusText.Text = "Starting dashboard...";
        //        });

        //        await Task.Delay(600);

        //        // 3️⃣ Fade out splash
        //        await splash.CloseWithFadeOut();

        //        // 4️⃣ Launch main shell with fade-in
        //        var shell = new AppShellFrame
        //        {
        //            Opacity = 0
        //        };
        //        shell.Show();

        //        var fadeIn = new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(500));
        //        shell.BeginAnimation(Window.OpacityProperty, fadeIn);

        //        // 5️⃣ Wire up navigation
        //        var nav = AppInitializer.GetService<NavigationService>();
        //        nav.Initialize(shell.MainContentFrame);
        //        nav.Navigate<CaseManagerView>();

        //        // Log startup
        //        var logger = AppInitializer.GetService<Remi.Fetch.Windows.Services.LoggingService>();
        //        logger.Log("Remi Fetch initialized with fade-in transition.");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Startup error: {ex.Message}", "Initialization Error",
        //            MessageBoxButton.OK, MessageBoxImage.Error);
        //        splash.Close();
        //    }
        //}
    }

}
