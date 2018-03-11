using School.DAL;
using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new SchoolContext())
            {
                var kurs = dbContext.Courses.Add(new Course()
                {
                    Name = ".NET Starter",
                    Code = "dotNet150",
                    Description = ".NET Course by Software Development Academy"
                });
                dbContext.SaveChanges();
                var newCourse = dbContext.Courses.First();
                foreach (var student in dbContext.Students)
                {
                    student.Course = newCourse;
                }
                dbContext.SaveChanges();
            }
            Console.WriteLine("Wykonano program.");
            Console.ReadLine();
        }


    
        }
    }

