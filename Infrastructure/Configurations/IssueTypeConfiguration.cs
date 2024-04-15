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
    public class IssueTypeConfiguration : IEntityTypeConfiguration<Issue_Type>
    {
        public void Configure(EntityTypeBuilder<Issue_Type> builder)
        {
            builder.ToTable("IssueType");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.IssueTypeName).IsRequired().HasMaxLength(128);
        }
    }
}
