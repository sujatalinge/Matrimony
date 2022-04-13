using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUDUsingAdoNet.Models
{ 

  
    public class Trainer
    {
        public int Id { get; set; }
        [Display(Name = "Trainer Name")]
        public string name { get; set; }

        public Nullable<long> Salary { get; set; }
    }
}