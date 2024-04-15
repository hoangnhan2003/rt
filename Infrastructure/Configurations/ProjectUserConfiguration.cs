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
    public class ProjectUserConfiguration : IEntityTypeConfiguration<Project_User>
    {
        public void Configure(EntityTypeBuilder<Project_User> builder)
        {
            builder.ToTable("ProjectUser");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.HasOne(p => p.Member_Roles).WithMany().HasForeignKey(p => p.MemberRoleId).IsRequired();
        }

    }
}
