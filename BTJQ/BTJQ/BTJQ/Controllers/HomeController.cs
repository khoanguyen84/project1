using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BTJQ.Models;
using BTJQ.Data;
using BTJQ.Models.Entities;

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
        
        public IActionResult Get(int id)
        {
            var student = new StudentDetail();
            try
            {
                student = appDBContext.Student
                        .Where(s => s.StudentId == id)
                        .Select(s => new StudentDetail()
                        {
                            ClassRoomId = s.ClassRoomId,
                            DOB = s.DOB,
                            FullName = s.FullName,
                            Sex = s.Sex ? 1 : 0,
                            StudentId = s.StudentId
                        }).FirstOrDefault();
                return new JsonResult(new { status = 1, response = student });
            }
            catch(Exception ex)
            {

            }
            return new JsonResult(new { status = -1, response = student });
        }

        public IActionResult GetClasses()
        {
            var classes = new List<ClassItem>();
            try
            {
                classes = (from c in appDBContext.ClassRoom
                           select new ClassItem()
                           {
                               Id = c.ClassRoomId,
                               Name = c.ClassName
                           }).ToList();
            }
            catch (Exception ex)
            {

            }
            return new JsonResult(new { response = classes, status = 1 });
        }

        [HttpPost]
        public IActionResult Save([FromBody] StudentSave model)
        {
            try
            {
                if(model != null)
                {
                    //create new student
                    if(model.StudentId == 0)
                    {
                        var student = new Student()
                        {
                            ClassRoomId = model.ClassRoomId,
                            DOB = model.DOB,
                            FullName = model.FullName,
                            Sex = model.Sex == 1 ? true : false,
                            StudentId = model.StudentId
                        };
                        appDBContext.Student.Add(student);

                        var saveResult = appDBContext.SaveChanges();
                        if (saveResult > 0)
                        {
                            return new JsonResult(new
                            {
                                status = 1,
                                message = "Student has been created successfully."
                            });
                        }
                    }
                    else //update student by StudentId
                    {
                        var studentDetail = appDBContext.Student.
                                            Where(s => s.StudentId == model.StudentId).
                                            FirstOrDefault();
                        studentDetail.FullName = model.FullName;
                        studentDetail.Sex = model.Sex == 1;
                        studentDetail.ClassRoomId = model.ClassRoomId;
                        studentDetail.DOB = model.DOB;
                        studentDetail.StudentId = model.StudentId;

                        appDBContext.Student.Update(studentDetail);
                        var updateResult = appDBContext.SaveChanges();
                        if (updateResult > 0)
                        {
                            return new JsonResult(new
                            {
                                status = 1,
                                message = "Student has been updated successfully."
                            });
                        }
                    }
                    
                }
                return new JsonResult(new
                {
                    status = -1,
                    message = "Something went wrong, please contact administrator."
                });
            }
            catch(Exception ex)
            {
                return new JsonResult(new
                {
                    status = -1,
                    message = "Something went wrong, please contact administrator."
                });

            }
        }
    }

}
