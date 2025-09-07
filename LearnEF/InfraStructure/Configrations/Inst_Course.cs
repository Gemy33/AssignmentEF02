using EF02.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.InfraStructure.Configrations
{
    internal class Inst_Course : IEntityTypeConfiguration<Domain.Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> builder)
        {
            builder.HasKey(ic => new { ic.InstructorID, ic.CourseID });
        }
    }
}
