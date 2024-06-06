using Azure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System.Models
{
    internal class Student
    {
     

        public int StudentId { get; set; }

        [MaxLength(100)]
        [Unicode(true)]
        public string Name { get; set; } = null!;
        [MaxLength(10)]
        [Unicode(false)]
        public string ? PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public string ? Birthday { get; set; }
        public List<StudentCourse>StudentCourses { get; }
        public List<Course> Courses { get; }
        public ICollection<Homework> Homeworks { get; } = new List<Homework>();

    }
}
