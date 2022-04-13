using CARINSURE.WEB.DataLayer;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CARINSURE.WEB.BusinessLayer
{
    public class RolesBL
    {
        RolesDB _db = null;
        public RolesBL()
        {
            _db = new RolesDB();
        }
        public List<IdentityRole> GetRoles()
        {
            return _db.GetRoles();
        }
        public bool Insert(IdentityRole role)
        {
            return _db.Insert(role);
        }
    }
}