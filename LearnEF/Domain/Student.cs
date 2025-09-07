using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Domain
{
    public class Student
    {
        public int ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        [ForeignKey(nameof(Department))]
        public int dept_id { get; set; }

        public Department Department { get; set; }
        public ICollection<Stud_Course> stud_Courses { get; set; } = new HashSet<Stud_Course>();
    }
}
