using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDUsingAdoNet.Models
{
    public class Student
    {
        public int Rollnumber { get; set; }
        public string name { get; set; }
        public string Gender { get; set; }
        public Nullable<int> TrainerId { get; set; }
         public Trainer Trainer { get; set; }
    }
}