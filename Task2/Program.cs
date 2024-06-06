using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Student_System.data;
using Student_System.Models;

namespace Student_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            //Student student = new Student() { Name = "Elgohary", PhoneNumber = "011112456", Birthday = "7/10/2001", RegisteredOn = DateTime.UtcNow };
            //context.Students.Add(student);
            //Student student1 = new Student() { Name = "Sohila", PhoneNumber = "011126556", Birthday = "24//8/2001", RegisteredOn = DateTime.UtcNow };
            //context.Students.Add(student1);
            ////لي لما بستخدم فانكشن ادد ورا بعض مبتضافش كلها مرا واحده
            //Course course = new Course() { Name = "mostafa", Description = "Backend", StartData = DateTime.UtcNow, EndData = DateTime.UtcNow, Price = 6.66 };
            //context.Courses.Add(course);
            //Course course1 = new Course() { Name = "mostafa", Description = "Backend", StartData = DateTime.UtcNow, EndData = DateTime.UtcNow, Price = 6.66 };
            //context.Courses.Add(course1);
            //Course course2 = new Course() { Name = "mostafa", Description = "Backend", StartData = DateTime.UtcNow, EndData = DateTime.UtcNow, Price = 6.66 };
            //context.Courses.Add(course2);
            //Course course3 = new Course() { Name = "mostafa", Description = "Backend", StartData = DateTime.UtcNow, EndData = DateTime.UtcNow, Price = 6.66 };
            //context.Courses.Add(course3);
            //context.SaveChanges();
            Resource resource = new Resource() { Name = "WikiPadia", resourceType = Resource.ResourceType.Document,CourseId=1 };
            context.Resources.Add(resource);
            context.SaveChanges();
            //Homework homework = new Homework() { Content = "true,false", contentType = Homework.ContentType.Application, SubmissionTime = DateTime.UtcNow };
            //context.Homeworks.Add(homework);
            //context.SaveChanges();
            //var result = context.Students.ToList();
            //foreach (var item in result) 
            //{
            //    Console.WriteLine($"{item.StudentId}"+$"--{item.Name}");
            //}
            //var result1 = context.Courses.ToList();
            //foreach (var item in result1)
            //{
            //    Console.WriteLine($"{item.Name}" + $"--{item.Description}");
            //}
            var s = context.studentCourses.Include(e => e.student).Include(e => e.course).Where(e => e.StudentId <= 8);
            foreach (var item in s)
            {
                Console.WriteLine($"{item.student.StudentId}+{item.course.Name}");
            }



        }
    }
}
