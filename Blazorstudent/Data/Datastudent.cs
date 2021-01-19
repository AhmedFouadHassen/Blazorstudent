using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazorstudent.Data
{
    public class Datastudent : Istudent
    {
        List<Student> Students = new List<Student>();
        public  IEnumerable<Student> students
        {
           get
            {
                return  new List<Student>
              {

 new Student {StudentID=1,StudentName="ahmed",StudentAge=12,StudenAddress="egypt" },
new Student {StudentID=2,StudentName="mohamed",StudentAge=12,StudenAddress="egypt" },
new Student {StudentID=3,StudentName="mostafa",StudentAge=12,StudenAddress="egypt" }
              };
                    
            }
        }

        public Task<IEnumerable<Student>> getasyns
        {
            get
            {
                return Task.FromResult(students);
            }
        }

        public void addstudent(Student student)
        {
            Students.Add(student);
        }

        public Student getstudentbyID(int id)
        {
            var stud = Students.SingleOrDefault(p => p.StudentID == id);
            return stud;
        }
    }
}
