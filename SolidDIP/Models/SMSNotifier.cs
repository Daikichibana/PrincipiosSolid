﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidDIP.Models
{
    public class SMSNotifier : INotifier
    {
        public string Notify(string message)
        {
            return "Se ha enviado correctamente la notificacion por SMS. " + message;
        }
    }
}
