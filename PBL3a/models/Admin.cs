using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3
{
    public class Admin : User 
    {
        public string responsibility { get; set; }
        public Admin(string user_Id, string user_name, string Password, string res)
        : base(user_Id, user_name, Password, UserRole.Admin)
        {
            responsibility = res;
        }
    }
}
