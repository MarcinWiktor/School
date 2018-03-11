using School.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DAL
{
    class SchoolInitializer : DropCreateDatabaseAlways<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            IList<Student> defaultStudents = new List<Student>();
            defaultStudents.Add(new Student()
            {
                Name = "Pawel",
                Surname = "Brejna",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Jakub",
                Surname = "Rzepka",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Vadym",
                Surname = "Khoma",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Michal",
                Surname = "Fic",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Daniel",
                Surname = "Ruzewicz",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Bartlomiej",
                Surname = "Zaczkowski",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Radek",
                Surname = "Dabrowski",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Marcin",
                Surname = "Wiktor",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Sebastian",
                Surname = "Szymanek",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Lukasz",
                Surname = "Debiec",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Artur",
                Surname = "Mykowski",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Krzysztof",
                Surname = "Dylewski",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            foreach (Student student in defaultStudents)
                context.Students.Add(student);
            base.Seed(context);
        }
    }
}
