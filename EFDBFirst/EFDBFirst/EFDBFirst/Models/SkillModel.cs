using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFDBFirst.Models
{
    public class SkillModel
    {
        [Key]
        public int Value { get; set; }
        public string Name { get; set; }
    }
}
