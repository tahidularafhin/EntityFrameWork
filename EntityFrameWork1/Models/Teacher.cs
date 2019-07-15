using CoreTest1000.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWork1.Models
{
    public class Teacher
    {

        public int Id { get; set; }
        public string Name { get; set; }



        public ICollection<StudentTeacher> StudentTeachers { get; set; }
        public ICollection<TeacherCourse> TeacherCourses { get; set; }
    }
}
