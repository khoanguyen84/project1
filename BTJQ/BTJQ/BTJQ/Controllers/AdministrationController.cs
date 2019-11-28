using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTJQ.Controllers
{
    public class AdministrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
