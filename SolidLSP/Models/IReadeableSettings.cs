using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidLSP.Models
{
    public interface IReadeableSettings
    {
        Dictionary<string, string> GetSettings();
    }
}
