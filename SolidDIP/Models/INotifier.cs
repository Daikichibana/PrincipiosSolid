using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidDIP.Models
{
    public interface INotifier
    {
        public string Notify(string message);
    }
}
