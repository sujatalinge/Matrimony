using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace CRUDUsingEFDBFirstApproach.Common
{
    public class AppKeys
    {
        public static bool EnableBundling
        {
            get
            {
                return bool.Parse(ConfigurationManager.AppSettings["enableBundling"].ToString());
            }
        }
    }
}