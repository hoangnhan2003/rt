using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class ActiveTypeConfigurations : IEntityTypeConfiguration<Active_Type>
    {
        public void Configure(EntityTypeBuilder<Active_Type> builder)
        {
            builder.ToTable("ActiveType");
            builder.HasKey(x => x.Id);
            builder.Property(d => d.Id).UseIdentityColumn();
            builder.Property(p => p.ActiveTypeName).IsRequired().HasMaxLength(128);
        }
    }
}
