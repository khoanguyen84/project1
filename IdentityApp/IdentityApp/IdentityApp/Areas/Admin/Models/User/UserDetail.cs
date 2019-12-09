using IdentityApp.Areas.Admin.Models.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityApp.Areas.Admin.Models.User
{
    public class UserDetail
    {
        public string UserId { get; set; }
        public bool Gender { get; set; }
        public string DOB { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string[] Roles { get; set; }
    }
}
