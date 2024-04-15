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
    public class GitConfiguration : IEntityTypeConfiguration<Git>
    {
        public void Configure(EntityTypeBuilder<Git> builder)
        {
            builder.ToTable("Git");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasMany(p => p.Git_Repos).WithOne(p => p.Git).HasForeignKey(p => p.Git_Id).IsRequired();
        }
    }
}

