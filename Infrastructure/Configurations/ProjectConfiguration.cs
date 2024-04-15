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
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p=> p.ProjectName).IsRequired().HasMaxLength(128);
            builder.Property(p => p.CreateAt).IsRequired().HasDefaultValueSql("GETDATE()");
            builder.HasMany(p => p.Wiki).WithOne(p => p.Project).HasForeignKey(p => p.Project_Id).IsRequired();
            builder.HasOne(p => p.Git).WithOne(p => p.Project).HasForeignKey<Git>(p => p.Project_Id).IsRequired();
            builder.HasMany(p => p.ProjectUsers).WithOne(p => p.Project).HasForeignKey(p => p.Project_Id).IsRequired();
            builder.HasMany(p => p.Issues).WithOne(p => p.Project).HasForeignKey(p => p.Project_Id).IsRequired();
            builder.HasMany(p => p.Histories).WithOne(p => p.Project).HasForeignKey(p => p.Project_Id).IsRequired();
        }
    }
}
