using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace CARINSURE.WEB
{
    public class ConfigKeys
    {
        public static string FromEmail
        {
            get
            {
                return ConfigurationManager.AppSettings["fromEmail"];
            }
        }
        public static string FromEmailPassword
        {
            get
            {
                return ConfigurationManager.AppSettings["FromEmailPassword"];
            }
        }

    }
}