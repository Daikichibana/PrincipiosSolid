using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidLSP.Models
{
    public class SettingsHelper
    {
        public static Dictionary<IReadeableSettings, Dictionary<string, string>> GetAllSettings(List<ISettings> items)
        {
            var allSettings = new Dictionary<IReadeableSettings, Dictionary<string, string>>();
            foreach (IReadeableSettings item in items)
            {
                allSettings.Add(item, item.GetSettings());
            }
            return allSettings;
        }

        public static List<string> SetAllSettings(List<IWritableSettings> items, List<Dictionary<string, string>> values)
        {
            List<string> messages = new List<string>();
            for (int i = 0; i < items.Count; i++)
            {
                messages.Add(items[i].SetSettings(values[i]));
            }
            return messages;
        }
    }
}
