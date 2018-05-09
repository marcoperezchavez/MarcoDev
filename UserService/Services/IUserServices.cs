using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer.data.Models;

namespace UserService.Services
{
    public interface IUserServices
    {
        List<User> GetUsers();

    }
}
