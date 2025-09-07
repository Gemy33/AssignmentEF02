using EF02.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EF02.InfraStructure.Configrations
{
    internal class InstConfig : IEntityTypeConfiguration<Domain.Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {

            //builder.HasOne(d => d.)
            //        .WithMany(i => i.Instructors)
            //        .HasForeignKey(d => d.department)
            //        .OnDelete(DeleteBehavior.NoAction);




        }
    }
}
