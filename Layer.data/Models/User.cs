using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.data.Models
{
    public class User
    {
        public int id { get; set; }
        public string email { get; set; }
        public string nickname { get; set; }
        public string pass { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dateCreated { get; set; }
        public int statusUserId { get; set; }
    }
}
