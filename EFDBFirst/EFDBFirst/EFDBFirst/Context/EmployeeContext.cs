using EFDBFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFDBFirst.Context
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        public DbSet<tblSkill> tblSkills { get; set; }
        public DbSet<tblEmployee> tblEmployees { get; set; }
        public DbSet<EmployeeViewModel> EmployeeViewModel { get; set; }
        public DbSet<EFDBFirst.Models.EmployeeCreateModel> EmployeeCreateModel { get; set; }
        public DbSet<EFDBFirst.Models.EmployeeEditModel> EmployeeEditModel { get; set; }
    }
}
