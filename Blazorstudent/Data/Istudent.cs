using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazorstudent.Data
{
  public  interface Istudent
    {
        [Inject]
      IEnumerable<Student> students { get; }

         Task<IEnumerable<Student>> getasyns { get; }
       void addstudent(Student student);

        Student getstudentbyID(int id);
        
    }
}
