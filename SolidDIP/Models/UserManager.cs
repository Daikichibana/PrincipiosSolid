using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidDIP.Models
{
    public class UserManager
    {
        public INotifier Notifier { get; set; }

        public UserManager(INotifier notifier)
        {
            this.Notifier = notifier;
        }

        public string ChangePassword(string username, string oldpwd, string newpwd)
        {
            return Notifier.Notify($"La clave de {username} fue cambiada exitomente de {oldpwd} a {newpwd}.");
        }
    }
}
