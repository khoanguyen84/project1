using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperMVC.Models.User
{
    public class UserView
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string DOB { get; set; }
        public string UserMobile { get; set; }
        public string UserEmail { get; set; }
        public string FaceBookUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string PersonalWebUrl { get; set; }
        public bool IsDeleted { get; set; }
        public string CountryName { get; set; }
        public string JobName { get; set; }
        public int YearOfExperience { get; set; }
    }
}
