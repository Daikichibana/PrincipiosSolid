using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidLSP.Models
{
    public class SectionSettings : IReadeableSettings, IWritableSettings
    {
        public Dictionary<string, string> GetSettings()
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();
            settings.Add("SectionName", "Sports");
            return settings;
        }

        public string SetSettings(Dictionary<string, string> settings)
        {
            return "Section settings saved on " + DateTime.Now;
        }
    }
}
