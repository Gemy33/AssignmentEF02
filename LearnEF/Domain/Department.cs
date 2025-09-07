using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Domain
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public DateOnly HiringDate { get; set; }



        [ForeignKey(nameof(Manager))]
        public int Inst_id { get; set; }

        public Instructor Manager { get; set; }


        public ICollection<Student> Students { get; set; } = new HashSet<Student>();


        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
    }

}
