using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDEMO1.Models
{
    public class Register
    {
        [Required(ErrorMessage="Email is required")]

      [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?
", ErrorMessage = "Invalid Email")]

        public string Email{ get; set; }


        [Required(ErrorMessage = "password is required")]
        public string Password { get; set; }



        [Required(ErrorMessage = "ConfirmPassword is required")]
        [Compare("Password", ErrorMessage ="Password & ConfirmPassword Passssword should be same")]
        [Display(Name = "ConfirmPassword")]
        public string ConfirmPassword { get; set; }
    }
}