using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreTest1000.Models;

namespace EntityFrameWork1.Models
{
    public class Course
    {

        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public int TeacherId { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
        public ICollection<TeacherCourse> TeacherCourses { get; set; }
    }
}
