using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTJQ.Models.Entities
{
    public class ClassRoom
    {
        [Key]
        public int ClassRoomId { get; set; }
        public string ClassName { get; set; }
    }
}
