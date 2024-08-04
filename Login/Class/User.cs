using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Class
{
    public class User
    {
        public string email { get; set; }
        public string password { get; set; }
        public DateTime last_data { get; set; }
    }
}
