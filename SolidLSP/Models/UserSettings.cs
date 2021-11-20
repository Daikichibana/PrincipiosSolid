using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidLSP.Models
{
    public class UserSettings : IReadeableSettings, IWritableSettings
    {
        public Dictionary<string, string> GetSettings()
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();
            settings.Add("UserName", "User1");
            return settings;
        }

        public string SetSettings(Dictionary<string, string> settings)
        {
            return "User settings saved on " + DateTime.Now;
        }
    }
}
