using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            return db.Users.Where(x => x.id == id).FirstOrDefault();
        }

        public bool SaveUser(data user)
        {
            try
            {
                db.Users.Add(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<data> GetUsers()
        {
            return db.Users.ToList();
        }

        public bool UpdateUser(int id, data user)
        {
            try
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}