using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidLSP.Models
{
    public interface ISettings
    {
        Dictionary<string, string> GetSettings();
        string SetSettings(Dictionary<string, string> settings);
    }
}
