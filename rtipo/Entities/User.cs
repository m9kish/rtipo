using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rtipo.Entities
{
    internal class User
    {
        public int Id { get; set; }
        public UserRole UserRole { get; set; }
        public Organisation Organisation { get; set; }
        public string Login { get;set; }
        public string Password { get;set; }
        public string First_name { get; set; }
        public string Middle_name { get; set; }
        public string Last_name { get; set; }
    }
}
