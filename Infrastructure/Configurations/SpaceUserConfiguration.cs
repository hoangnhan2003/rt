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
    public class SpaceUserConfiguration : IEntityTypeConfiguration<Space_User>
    {
        public void Configure(EntityTypeBuilder<Space_User> builder)
        {
            builder.ToTable("SpaceUser");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.HasOne(p => p.Member_Roles).WithMany().HasForeignKey(p => p.MemberRoleId).IsRequired();
        }
    }
}
