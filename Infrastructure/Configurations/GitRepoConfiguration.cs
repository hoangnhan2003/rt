using Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class GitRepoConfiguration : IEntityTypeConfiguration<Git_Repo>
    {
        public void Configure(EntityTypeBuilder<Git_Repo> builder)
        {
            builder.ToTable("GitRepo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(p => p.GitRepoUrl).IsRequired().HasMaxLength(500);
        }
    }
}
