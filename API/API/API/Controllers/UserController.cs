using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BAL.Interface;
using Domain;
using Domain.Request;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        // GET api/values
        [HttpGet]
        [Route("api/user/gets")]
        public IList<UserView> Gets()
        {
            return _userService.GetAllUser();
        }

        // GET api/values/5
        [HttpGet]
        [Route("api/user/get/{id}")]
        public User Get(int id)
        {
            return _userService.GetUserById(id);
        }

        // POST api/values
        [HttpPost]
        [Route("api/user/create")]
        public int Create([FromBody] User user)
        {
            return _userService.AddUser(user);
        }

        // PUT api/values/5
        [HttpPut]
        [Route("api/user/update")]
        public bool Update([FromBody] User user)
        {
            return _userService.UpdateUser(user);
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("api/user/delete")]
        public bool Delete([FromBody]UserDeleteRequest request)
        {
            return _userService.DeleteUser(request.Id);
        }
    }
}
