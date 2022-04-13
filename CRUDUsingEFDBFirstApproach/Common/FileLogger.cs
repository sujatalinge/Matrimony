using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CRUDUsingEFDBFirstApproach.Common
{
    public class FileLogger
    {
        public void LogToFile(string message)
        {
            string folderpath = HttpContext.Current.Server.MapPath("~/Data/");

         //   File.AppendAllText($"{folderpath}/logs.txt", "\n****** New Log ******");


            //    File.WriteAllText($"{folderpath}/logs.txt", message);
          //  File.AppendAllText($"{folderpath}/logs.txt", message);

        }
    }
}