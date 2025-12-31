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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Remi.Fetch.Views
{
    /// <summary>
    /// Interaction logic for SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        private readonly string[] _messages = new[]
        {
            "Loading configuration...",
            "Connecting to database...",
            "Initializing modules...",
            "Starting dashboard..."
        };

        public SplashScreen()
        {
            InitializeComponent();
            this.Opacity = 0;
            FadeIn();
            StartMessageRotation();
        }

        private async void FadeIn()
        {
            var fadeIn = new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(400));
            this.BeginAnimation(Window.OpacityProperty, fadeIn);
            await Task.Delay(3000); // display splash for ~3 seconds total
        }

        public async Task CloseWithFadeOut()
        {
            var fadeOut = new DoubleAnimation(1, 0, TimeSpan.FromMilliseconds(400));
            this.BeginAnimation(Window.OpacityProperty, fadeOut);
            await Task.Delay(400);
            this.Close();
        }

        private async void StartMessageRotation()
        {
            await Task.Delay(400); // wait slightly before first message

            foreach (var msg in _messages)
            {
                await FadeMessageAsync(msg);
                await Task.Delay(600); // wait before next fade
            }
        }

        private async Task FadeMessageAsync(string message)
        {
            // Fade out (if visible)
            var fadeOut = new DoubleAnimation(1, 0, TimeSpan.FromMilliseconds(250));
            StatusText.BeginAnimation(OpacityProperty, fadeOut);
            await Task.Delay(250);

            // Update text
            Dispatcher.Invoke(() => StatusText.Text = message);

            // Fade in new message
            var fadeIn = new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(350));
            StatusText.BeginAnimation(OpacityProperty, fadeIn);
            await Task.Delay(350);
        }
    }
}
