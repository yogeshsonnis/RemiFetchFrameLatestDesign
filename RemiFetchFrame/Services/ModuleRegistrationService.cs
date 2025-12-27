using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RemiFetchFrame.Services
{
    public class ModuleRegistrationService
    {
        public static List<ModuleInfo> Modules { get; private set; } = new();

        public static void LoadModules()
        {
            try
            {
                var jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NavigationConfig.json");
                if (!File.Exists(jsonPath))
                {
                    Modules.Clear();
                    return;
                }

                var json = File.ReadAllText(jsonPath);
                var config = JsonSerializer.Deserialize<ModuleConfig>(json);
                Modules = config?.Modules ?? new List<ModuleInfo>();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[ModuleRegistrationService] Error: {ex.Message}");
            }
        }

        public static UserControl? CreateViewInstance(string typeName)
        {
            try
            {
                var type = Type.GetType(typeName);
                if (type == null)
                    return null;

                return (UserControl)Activator.CreateInstance(type)!;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[ModuleRegistrationService] Failed to create {typeName}: {ex.Message}");
                return null;
            }
        }
    }

    public class ModuleConfig
    {
        public List<ModuleInfo> Modules { get; set; } = new();
    }

    public class ModuleInfo
    {
        public string Name { get; set; } = string.Empty;
        public string View { get; set; } = string.Empty;
    }
}
