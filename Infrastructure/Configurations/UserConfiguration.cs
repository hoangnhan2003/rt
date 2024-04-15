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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.FullName).IsRequired().HasMaxLength(128);
            builder.Property(p => p.Password).IsRequired().HasMaxLength(128);
            builder.Property(p => p.Email).IsRequired().HasMaxLength(128);
            builder.HasMany(p => p.Project_Users).WithOne(p => p.Users).HasForeignKey(p => p.User_Id).OnDelete(DeleteBehavior.Restrict).IsRequired();
            builder.HasMany(p => p.Space_Users).WithOne(p => p.Users).HasForeignKey(p => p.User_Id).OnDelete(DeleteBehavior.Restrict).IsRequired();
        }
    }
}
