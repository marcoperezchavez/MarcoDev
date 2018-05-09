using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Application.Data;
using Microsoft.Ajax.Utilities;
using Service.Services;

namespace WebApiV1.Controllers
{
    public class UserController : ApiController
    {
        private IUserService _userService = new UserService();

        [HttpGet]
        public IEnumerable<data> Get()
        {
            return _userService.GetUsers();
        }
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var user = _userService.GetUser(id);

            if (user == null)
                return NotFound();
            return Ok(user);
        }
             [HttpPost]
        public IHttpActionResult Post(data user)
        {
            var isSave = _userService.SaveUser(user);

            if (isSave)
                return Ok();
            return BadRequest();
        }
        [HttpPut]
        public IHttpActionResult Put(data user)
        {
            var isUpdated = _userService.UpdateUser(user.id, user);      

            if (isUpdated)
                return Ok();
            return BadRequest();
        }







    }
}
