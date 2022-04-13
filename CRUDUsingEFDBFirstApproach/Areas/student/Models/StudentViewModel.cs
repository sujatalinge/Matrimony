using CRUDUsingEFDBFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUDUsingEFDBFirstApproach.Areas.student.Models
{
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {

    }
    public class StudentMetadata
    {
        [Required]
        public int RollNumber { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]

        public string Gender { get; set; }
        public Nullable<int> Trainerid { get; set; }

        public virtual Trainer Trainer { get; set; }

    }
}