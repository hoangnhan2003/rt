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
    public class WikiConfiguration : IEntityTypeConfiguration<Wiki>
    {
        public void Configure(EntityTypeBuilder<Wiki> builder)
        {
            builder.ToTable("Wiki");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.WikiContent).IsRequired().HasColumnType("nvarchar(max)");
        }
    }
}
