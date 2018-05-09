using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Layer.data.Models;

namespace UserService.Services
{
    public class UserServices : IUserServices
    {
        private string URL = ConfigurationManager.AppSettings["UrlWebApiUser"];
        public List<User> GetUsers()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            //var response = client.GetAsync(URL).Result;

            var response = client.GetStringAsync(URL).Result;


            return null;

        }
    }
}
