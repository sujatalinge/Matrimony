using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDEMO1.Models
{
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string RememberMe { get; set; }
    }
    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
    }
}