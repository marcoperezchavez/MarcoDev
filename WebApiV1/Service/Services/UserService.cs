using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Application.Data;

namespace Service.Services
{
    public class UserService : IUserService
    {
        private UsersDBEntities db = new UsersDBEntities();   

        public data GetUser(int id)
        {
            return null;
        }

        public List<data> GetUsers()
        {
            return db.Users.ToList();
        }
    }
}