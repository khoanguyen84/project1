using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityApp.Areas.Admin.Models.User
{
    public class UserSave
    {
        public string UserId { get; set; }
        public bool Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string[] Roles { get; set; }
    }
}
