using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BTJQ.Models;
using BTJQ.Data;

namespace BTJQ.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDBContext appDBContext;

        public HomeController(AppDBContext _appDBContext)
        {
            appDBContext = _appDBContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Gets()
        {
            try 
            {
                //LinQ
                //Lambda
                var students = new List<StudentModelView>();
                students = (from s in appDBContext.Student
                            join c in appDBContext.ClassRoom on s.ClassRoomId
                            equals c.ClassRoomId
                            select new StudentModelView()
                            {
                                ClassName = c.ClassName,
                                DOB = s.DOB.ToString("dd/MM/yyyy"),
                                FullName = s.FullName,
                                Sex = s.Sex ? "Male" : "Female",
                                StudentId = s.StudentId
                            }).ToList();

                return new JsonResult(new { response = students, status = 1 });
            }
            catch (Exception ex) 
            {
                return new JsonResult(new { status = -1, 
                                        message="Something went wrong, please contact administrator." });
            }
            
        }
        
    }

}
