using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazorstudent.Data
{
    public class Student
    {
        [Required(ErrorMessage ="ادخل رقم الطالب")]
        public int StudentID { get; set; }

        public string StudentName { get; set; }
        [Range(10, 80, ErrorMessage = "العمر ما بين 10 سنوات و82")]
        public int StudentAge { get; set; }

        public string StudenAddress { get; set; }
    }
}
