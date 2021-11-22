using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolidDIP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidDIP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotifyController : ControllerBase
    {
        [HttpPost]
        public void ChangePassword(string notificationType)
        {
            INotifier notifier = null;

            switch (notificationType)
            {
                case "email":
                    notifier = new EmailNotifier();
                    break;
                case "sms":
                    notifier = new SMSNotifier();
                    break;
                case "popup":
                    notifier = new PopupNotifier();
                    break;
            }

            UserManager mgr = new UserManager(notifier);
            mgr.ChangePassword("user1", "oldpwd", "newpwd");

        }
    }
}
