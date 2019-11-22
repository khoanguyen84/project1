using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTJQ.Models
{
    public class StudentSave
    {
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public DateTime DOB { get; set; }
        public int Sex { get; set; }
        public int ClassRoomId { get; set; }
    }
}
