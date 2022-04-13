using CRUDUsingEFDBFirstApproach.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
//using System.Web.Mvc;

namespace CRUDUsingEFDBFirstApproach.Models
{
    [MetadataType(typeof(ResiterMetadata))]
    public partial class Register
    {
        [ScaffoldColumn(false)]
        public string MyNewField { get; set; }

        [Display(Name ="Confirm Password")]
        [Compare("Password", ErrorMessage = "password and confirm password should be same")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Confirm Email")]
        [Compare("Email", ErrorMessage= "Email and confirm email should be same")]
        public string ConfirmEmail { get; set; }

        [DisplayFormat(DataFormatString ="dddd, dd MMMM yyyy")]
        public DateTime DateOfBirth { get; set; }
    }
    public class ResiterMetadata
    {
        [System.Web.Mvc.HiddenInput]
        public int Id { get; set; }

        [Display(Name = "User Name"),Required(ErrorMessage = "User name is required")]
      //  [StringLength(20, MinimumLength =2,ErrorMessage = "user name cannot exceed 20 character")]
        [MaxLength(20, ErrorMessage = "user name cannot exceed 20 character")]
        // [System.Web.Mvc.Remote("IsUserNameExists", "Account", ErrorMessage ="UserName is already taken")]
        [CustomRemoteValidation("IsUserNameExists", "Account", ErrorMessage = "UserName is already taken")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "password is required")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,15}$", ErrorMessage = "password should contains at least one capital letter,small letter ,special character and digit")]
       // [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "age is required")]
        [Range(typeof(int),"1","150" ,ErrorMessage = "age should be between 1 and 150" )]
        public Nullable<int> Age { get; set; }

        [Required(ErrorMessage = "email is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Invalid email")]
        // [DataType(DataType.EmailAddress)]

        public string Email { get; set; }

    }
}