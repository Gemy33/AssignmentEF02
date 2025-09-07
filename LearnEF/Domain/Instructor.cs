using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Domain
{
    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int HourRate { get; set; }
        public decimal Salary { get; set; }
        public  int Bouns { get; set; }


        [InverseProperty(nameof(Department.Manager))]
        public Department? ManagedDepartment { get; set; }   

        [InverseProperty(nameof(Department.Instructors))]
        public Department? WorkDepartment { get; set; }      




        public ICollection<Course_Inst> course_Insts = new HashSet<Course_Inst>();
    }
}
