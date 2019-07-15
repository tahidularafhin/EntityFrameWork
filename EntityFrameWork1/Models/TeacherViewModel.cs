using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWork1.Models
{
    public class TeacherViewModel
    {
        [Display(Name="Teacher name")]
        public string TeacherName { get; set; }

        public int CourseId { get; set; }

        [Display(Name = "Course name")]
        public string CourseName { get; set; }
    }
}
