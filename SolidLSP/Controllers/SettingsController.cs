using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolidLSP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidLSP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        public static List<IReadeableSettings> readeableSettings = new List<IReadeableSettings>();
        public static List<IWritableSettings> writableSettings = new List<IWritableSettings>();

        [HttpGet]
        public void SetSettings()
        {
            GlobalSettings g = new GlobalSettings();
            SectionSettings s = new SectionSettings();
            UserSettings u = new UserSettings();
            GuestSettings gu = new GuestSettings();
            readeableSettings.Add(g);
            readeableSettings.Add(s);
            readeableSettings.Add(u);
            readeableSettings.Add(gu);

            writableSettings.Add(g);
            writableSettings.Add(s);
            writableSettings.Add(u);
        }

        [HttpPost]
        public List<string> Save()
        {
            List<Dictionary<string, string>> newSettings = new List<Dictionary<string, string>>();

            Dictionary<string, string> app = new Dictionary<string, string>();
            app.Add("Theme", "Winter");

            Dictionary<string, string> sec = new Dictionary<string, string>();
            sec.Add("Title", "Music");

            Dictionary<string, string> usr = new Dictionary<string, string>();
            usr.Add("DisplayName", "Tom");

            Dictionary<string, string> gst = new Dictionary<string, string>();
            gst.Add("GuestName", "Jerry");

            newSettings.Add(app);
            newSettings.Add(sec);
            newSettings.Add(usr);
            newSettings.Add(gst);

            List<string> model = SettingsHelper.SetAllSettings(writableSettings, newSettings);
            return model;
        }

    }
}
