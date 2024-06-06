using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        [MaxLength(80)]
        [Unicode(true)]
        public string Name { get; set; } = null!;
        public string ? Description  { get; set; }
        public DateTime StartData { get; set; }
        public DateTime EndData { get; set; }
        public double Price { get; set; }
        public List<StudentCourse> StudentCourses { get; }
        public List<Student> Students { get; }
        public ICollection<Resource> Resources { get; } = new List<Resource>();
        public ICollection<Homework> Homeworks { get; } = new List<Homework>();



    }
}
