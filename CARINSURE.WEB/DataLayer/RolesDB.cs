using CARINSURE.WEB.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CARINSURE.WEB.DataLayer
{
    public class RolesDB
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public List<IdentityRole> GetRoles()
        {
            return db.Roles.ToList();

        }
    //    public List<IdentityRole> GetRolesById(int rollId)
      //  {
       //     return db.Roles.

        //}
        public bool Insert(IdentityRole role)
        {
            try
            {
                db.Roles.Add(role);
                db.SaveChanges();

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

    }
}