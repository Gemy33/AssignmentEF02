using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Domain
{
    [Table("InstructorCourse")]
    public class Course_Inst
    {
        [ForeignKey(nameof(Instructor))]
        public int InstructorID { get; set; }
        public Instructor Instructor { get; set; }

        [ForeignKey(nameof(Course))]
        public int CourseID { get; set; }
        public Course Course { get; set; }
    }
}
