using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3
{
    public class Class
    {
        public string classID { get; set; }
        public string class_name { get; set; }
        public string courseID { get; set; }
        public virtual Course Course { get; set; } // Navigation Property
        public string teacherID { get; set; }
        public virtual Teacher Teacher { get; set; } // Navigation Property
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public int capacity { get; set; }
        public bool IsFinished => DateTime.Now > end_date;
        public Class() { }
        public Class(string classId, string className, string courseId, string teacherId, DateTime start, DateTime end, int Capacity)
        {
            classID = classId;
            class_name = className;
            courseID = courseId;
            teacherID = teacherId;
            start_date = start;
            end_date = end;
            capacity = Capacity;
        }
    }
}
