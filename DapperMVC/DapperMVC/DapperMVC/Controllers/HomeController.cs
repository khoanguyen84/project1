using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DapperMVC.Models;
using DapperMVC.DAL;

namespace DapperMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly GroupMeetingService groupMeetingService = new GroupMeetingService();
        private readonly RoomService roomService = new RoomService();
        public IActionResult Index()
        {
            return View(groupMeetingService.GetGroupMeetings());
        }

        public IActionResult Create()
        {
            ViewBag.Rooms = GetRooms();
            return View();
        }

        [HttpPost]
        public IActionResult Create(GroupMeetingCreate model)
        {
            var createResult = groupMeetingService.AddGroupMeeting(new GroupMeeting() {
                Description = model.Description,
                GroupMeetingDate = model.GroupMeetingDate,
                GroupMeetingLeadName = model.GroupMeetingLeadName,
                ProjectName = model.ProjectName,
                TeamLeadName = model.TeamLeadName,
                RoomId = model.RoomId
            });
            if (createResult > 0)
            {
                TempData["Success"] = "Group meeting has been created success";
            }
            else
            {
                TempData["Error"] = "Something went wrong, please try again later";
            }
            ModelState.Clear();
            ViewBag.Rooms = GetRooms();
            return View(new GroupMeetingCreate() { GroupMeetingDate = DateTime.Now });
        }

        private List<RoomView> GetRooms()
        {
            var response = roomService.GetRooms();
            var data = response.Select(s => new RoomView() {
                Name = s.RoomName,
                Value = s.Id
            }).ToList();
            return data;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
