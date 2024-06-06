using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Student_System.Models
{
    internal class Resource
    {
        public int ResourceId { get; set; }
        [MaxLength(50)]
        [Unicode(true)]
        public string Name { get; set; } = null!;

        public ResourceType resourceType { get; set; }
        public enum ResourceType 
        {
            Video,
            Presentation,
            Document,
            Other
        }
        public int CourseId { get; set; }
        public Course course { get; set; } = null!;


    }
}
