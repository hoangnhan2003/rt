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
    public class IssueConfiguration : IEntityTypeConfiguration<Issue>
    {
        public void Configure(EntityTypeBuilder<Issue> builder)
        {
            builder.ToTable("Issue");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Content).IsRequired().HasMaxLength(128);
            builder.Property(p => p.Subject).IsRequired().HasMaxLength(128);
            builder.Property(p => p.CreateAt).IsRequired().HasDefaultValueSql("GETDATE()");
            builder.HasMany(p => p.Comment).WithOne(p => p.Issue).HasForeignKey(p => p.Issue_Id).IsRequired();
            builder.HasOne(i => i.Statuses).WithMany().HasForeignKey(i => i.Status_Id);
            builder.HasOne(i => i.Priority).WithMany().HasForeignKey(i => i.Priority_Id);
            builder.HasOne(i => i.Issue_Types).WithMany().HasForeignKey(i => i.IssueType_Id);
            builder.HasOne(i => i.Categories).WithMany().HasForeignKey(i => i.Category_Id);
        }
    }
}

