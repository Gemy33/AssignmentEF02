using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Domain
{
    public class Course
    {
        public int ID { get; set; }

        public int Duration { get; set; }

        public string Description { get; set; }
        public string Name { get; set; }

        [ForeignKey(nameof(Topic))]
        public int top_id { get; set; }
        public Topic Topic { get; set; }
        public ICollection<Stud_Course> stud_Courses { get; set; } = new HashSet<Stud_Course>();

        public ICollection<Course_Inst>course_Insts= new HashSet<Course_Inst>();
    }
}
