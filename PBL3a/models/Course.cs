
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3
{
    public class Course
    {
        public Course() { }
        public string courseID { get; set; }
        public string course_name { get; set; }
        public string description { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public int max_students { get; set; }
        public Course (string CourseID, string Course_name, string Description, DateTime Start, DateTime End, int max_st)
        {
            courseID = CourseID;
            course_name = Course_name;
            description = Description;
            start_date = Start;
            end_date = End;
            max_students = max_st;
        }
    }
}
