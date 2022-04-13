using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUDUsingEFDBFirstApproach.Models
{
    [MetadataType(typeof(TrainerMetadata))]
    public partial class Trainer
    {
       
    }
     public class TrainerMetadata
    {
        [Display(Name = "Trainer Name")]
        public string Name { get; set; }

    }
}