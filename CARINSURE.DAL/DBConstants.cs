using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARINSURE.DAL

{
     public   class DBConstants
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["CarInsureDB"].ConnectionString;
            }
        }
        public const string spGetInsuranceProviders = "usp_GetInsuranceProviders";

        public const string spGetPoliciesAllProviders = "usp_GetPoliciesAllProviders";
    }
}
