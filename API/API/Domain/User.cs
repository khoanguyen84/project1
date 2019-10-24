using System;

namespace Domain
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime DOB { get; set; }
        public string UserMobile { get; set; }
        public string UserEmail { get; set; }
        public string FaceBookUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string PersonalWebUrl { get; set; }
        public bool IsDeleted { get; set; }
        public int CountryId { get; set; }
        public int JobId { get; set; }
        public string Avatar { get; set; }
    }
}
