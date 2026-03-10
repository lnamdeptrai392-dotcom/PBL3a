using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3
{
    public enum UserRole
    {
        Student,
        Teacher,
        Admin
    }
    public class User
    {
        public string userID { get; private set; }
        private string username { get; set; } 
        private string password { get; set; } 
        public string fullname { get; set; } 
        public string address { get; set; } 
        public string email { get; set; } 
        public string phone { get; set; } 
        public UserRole role { get; set; }
        protected User(string user_Id, string user_name, string Password, UserRole Role)
        {
            userID = user_Id;
            username = user_name;
            password = Password;
            role = Role;
        }
        protected User() { }
    }
}
