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
    public class MemberRoleConfiguration : IEntityTypeConfiguration<Member_Role>
    {
        public void Configure(EntityTypeBuilder<Member_Role> builder)
        {
            builder.ToTable("MemberRole");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.RoleName).IsRequired().HasMaxLength(128);
        }
    }
}
