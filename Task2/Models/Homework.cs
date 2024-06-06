using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Student_System.Models
{
    internal class Homework
    {
        //        o HomeworkId
        //        o Content(string, linking to a file, not unicode)
        //o ContentType(enum – can be Application, Pdf or Zip)
        //o SubmissionTime
        //o StudentId
        //o CourseId
        public int HomeworkId { get; set; }
        [Unicode(false)]
        public string Content { get; set; } = null!;
        public ContentType contentType { get; set; }
        public enum ContentType { Application, Pdf , Zip }
        public DateTime SubmissionTime { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student student { get; set; } =null!;
        public Course course { get; set; } = null!;
    }
}
