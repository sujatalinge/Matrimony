using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace CRUDUsingAdoNet
{
    public static class Dbconstants
    {
         public static string connectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["B17MVCDB"].ConnectionString;
            }
        }

        public static string spGetTrainers = "usp_GetTrainers";


        public static string spGetStudentsByTrainerid = "usp_GetStudentsByTrainerid";

        public static string spGetStudentDetailsByRollNumber = "uspGetStudentDetailsByRollNumber";

        public static string spCreateTrainer = "usp_CreateTrainer";
        public static string spUpdateTrainer = "usp_UpdateTrainer";

        public static string spDeleteTrainer = "usp_DeleteTrainer";
    }
}