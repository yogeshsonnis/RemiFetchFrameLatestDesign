using Remi.Fetch.Services;
using Remi.Fetch.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace Remi.Fetch
{
   public static class AppExtensions
    {
        public static void RegisterModules(this Application app)
        {
            ModuleRegistrationService.LoadModules();
        }

        /// <summary>
        /// Displays the integrated module host inside the specified ContentControl.
        /// </summary>
        public static void LoadModuleHost(this ContentControl target)
        {
            var host = new ModuleViewHost();
            target.Content = host;
        }
    }
}
