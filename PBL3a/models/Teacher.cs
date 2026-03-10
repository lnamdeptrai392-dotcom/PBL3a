using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3
{
    public class Teacher : User
    {
        public long salary_base { get; set; }
        public string subject { get; set;}
        public DateTime dob { get; set; }
        public Gender gender { get; set; }
        public Teacher(string user_Id, string user_name, string Password, long Salary_base, string Subject, DateTime dateOfBirth, Gender sex)
        : base(user_Id, user_name, Password, UserRole.Teacher)
        {
            salary_base = Salary_base;
            subject = Subject;
            dob = dateOfBirth;
            gender = sex;
        }
    }
}
