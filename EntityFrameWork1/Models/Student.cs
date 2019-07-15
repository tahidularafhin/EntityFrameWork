using CoreTest1000.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWork1.Models
{
    
    public class Student
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        
        
        public ICollection<StudentCourse> StudentCourses { get; set; }
        public ICollection<StudentTeacher> StudentTeachers { get; set; }
    }
}
