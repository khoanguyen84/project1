using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DapperMVC.Models
{
    public class GroupMeetingView
    {
        public int Id { get; set; }

        public string ProjectName { get; set; }
        public string LeadName { get; set; }
        public string TeamLeadName { get; set; }
        public string Description { get; set; }

        public string MeetingDate { get; set; }
        public string Lead => $"{TeamLeadName} - {LeadName}";
        public string RoomName { get; set; }
    }
}
