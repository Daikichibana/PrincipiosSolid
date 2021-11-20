using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidLSP.Models
{
    public interface IWritableSettings
    {
        string SetSettings(Dictionary<string, string> settings);
    }
}
