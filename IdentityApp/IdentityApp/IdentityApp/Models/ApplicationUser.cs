using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public bool Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
    }
}
