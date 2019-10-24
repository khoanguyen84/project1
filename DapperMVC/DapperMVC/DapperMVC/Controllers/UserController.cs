using DapperMVC.Models.Country;
using DapperMVC.Models.Job;
using DapperMVC.Models.User;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DapperMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IHostingEnvironment _appEnvironment;
        public UserController(IHostingEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index2()
        {
            var users = new List<UserView>();
            var url = "http://localhost:63868/api/user/gets";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }

                users = JsonConvert.DeserializeObject<List<UserView>>(responseData);
            }
            return View(users);
        }

        public IActionResult Create()
        {
            TempData["Success"] = null;
            return View();
        }

        public IActionResult Details(int id)
        {
            var user = new UserView();
            var url = "http://localhost:63868/api/user/get/" + id;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }

                user = JsonConvert.DeserializeObject<UserView>(responseData);
            }
            return View(user);
        }

        [HttpPost]
        public IActionResult Create(UserCreate model)
        {
            var createResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:63868/api/user/create");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                createResult = bool.Parse(result);
            }
            if (createResult)
            {
                TempData["Success"] = "User has been created successfully";
            }
            ModelState.Clear();
            return View(new UserCreate() { });
        }

        public IActionResult Edit(int id)
        {
            var userEdit = new UserEdit();
            var url = "http://localhost:63868/api/user/get/" + id;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }

                userEdit = JsonConvert.DeserializeObject<UserEdit>(responseData);
            }
            ViewBag.Countries = GetCountries();
            return View(userEdit);
        }

        [HttpPost]
        public IActionResult Edit(UserEdit model)
        {
            var files = HttpContext.Request.Form.Files;
            foreach (var Image in files)
            {
                if (Image != null && Image.Length > 0)
                {
                    var file = Image;
                    //There is an error here
                    var uploads = Path.Combine(_appEnvironment.WebRootPath, "Contents\\Upload");
                    if (file.Length > 0)
                    {
                        var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                        using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                        {
                            file.CopyTo(fileStream);
                            model.Avatar = $"{uploads}\\{fileName}";
                        }
                    }
                }
            }

            var updateResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:63868/api/user/update");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                updateResult = bool.Parse(result);
            }
            if (updateResult)
            {
                TempData["Success"] = "User has been update successfully";
            }
            return RedirectToAction("Index", "User");
        }

        public IActionResult Delete(int id)
        {
            var model = new UserDeleteModel()
            {
                Id = id
            };
            var deleteResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:63868/api/user/delete");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "DELETE";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                deleteResult = bool.Parse(result);
            }
            return RedirectToAction("Index", "User");
        }

        private List<Country> GetCountries()
        {
            var countries = new List<Country>();
            var url = "http://localhost:63868/api/country/gets";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }

                countries = JsonConvert.DeserializeObject<List<Country>>(responseData);
            }
            return countries;
        }

        public JsonResult GetUsers()
        {
            var users = new List<UserView>();
            var url = "http://localhost:63868/api/user/gets";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }

                users = JsonConvert.DeserializeObject<List<UserView>>(responseData);
            }
            return Json(new { response = users, code = 1 });
        }
        [HttpPost]
        public JsonResult Save([FromBody] UserCreate model)
        {
            var createResult = 0;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:63868/api/user/create");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                createResult = int.Parse(result);
            }
            if (createResult > 0)
            {
                return Json(new { status = 1, message = "User has been created successfully." });
            }
            return Json(new { status = 0, message = "Something went wrong, please contact administrator." });
        }

        public JsonResult GetCountry()
        {
            var countries = GetCountries();
            return Json(new { response = countries, code = 1 });
        }

        public JsonResult GetJob()
        {
            var jobs = new List<Job>();
            var url = "http://localhost:63868/api/country/getjobs";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }

                jobs = JsonConvert.DeserializeObject<List<Job>>(responseData);
            }
            return Json(new { response = jobs, code = 1 });
        }

        public JsonResult Get(int id)
        {
            var userEdit = new UserEdit();
            var url = "http://localhost:63868/api/user/get/" + id;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }

                userEdit = JsonConvert.DeserializeObject<UserEdit>(responseData);
            }
            return Json(new { response = userEdit, code = 1 });
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}