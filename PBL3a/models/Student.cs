using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3
{
    using System;

    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public class Student : User
    {
        public string parent_phone { get; set; }
        public DateTime dob { get; set; }
        public Gender Gender { get; set; }
        public Student(string user_Id, string user_name, string Password,  string parentPhone, DateTime dateOfBirth, Gender sex)
        : base(user_Id, user_name, Password, UserRole.Student)
        {
            parent_phone = parentPhone;
            dob = dateOfBirth;
            Gender = sex;
        }
    }
}
