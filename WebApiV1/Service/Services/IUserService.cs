using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Data;

namespace Service.Services
{
    public interface IUserService
    {    
        List<data> GetUsers();
        data GetUser(int id);


    }
}
