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
    public class SpaceConfiguration : IEntityTypeConfiguration<Space>
    {
        public void Configure(EntityTypeBuilder<Space> builder)
        {
            builder.ToTable("Space");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.SpaceName).IsRequired().HasMaxLength(128);
            builder.Property(p => p.CreateAt).IsRequired().HasDefaultValueSql("GETDATE()");
            builder.HasMany(p => p.Projects).WithOne(p => p.Space).HasForeignKey(p => p.Space_Id).IsRequired().OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.Space_Users).WithOne(p => p.Space).HasForeignKey(p => p.Space_Id).OnDelete(DeleteBehavior.Restrict).IsRequired();
        }
    }
}
