using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Domain
{
    [Table("StudentCourse")]
    public class Stud_Course
    {

        [ForeignKey(nameof(Student))]
        public int StudentID { get; set; }
        public Student Student { get; set; }


        [ForeignKey(nameof(Course))]
        public int CourseID { get; set; }
        public Course Course { get; set; }

    }
}
