using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PESEL { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
