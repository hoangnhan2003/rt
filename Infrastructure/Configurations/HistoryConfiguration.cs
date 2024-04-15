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
    public class HistoryConfiguration : IEntityTypeConfiguration<History>
    {
        public void Configure(EntityTypeBuilder<History> builder)
        {
            builder.ToTable("History");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Message).IsRequired().HasMaxLength(500);
            builder.Property(p => p.CreateAt).IsRequired().HasDefaultValueSql("GETDATE()");
            builder.HasOne(i => i.User).WithMany().HasForeignKey(i => i.User_Id);
            builder.HasOne(i => i.Active_Types).WithMany().HasForeignKey(i => i.ActiveTypeId);
        }
    }
}
