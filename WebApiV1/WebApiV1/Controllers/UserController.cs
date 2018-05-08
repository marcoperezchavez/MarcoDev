using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Application.Data;
using Service.Services;

namespace WebApiV1.Controllers
{
    public class UserController : ApiController
    {
        private IUserService _userService = new UserService();

        public IEnumerable<data> Get()
        {
            return _userService.GetUsers();
        }





    }
}
