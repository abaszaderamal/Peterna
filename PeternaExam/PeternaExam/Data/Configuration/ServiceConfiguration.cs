using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PeternaExam.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeternaExam.Data.Configuration
{
    public class ServiceConfiguration:IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.Property(s => s.Icon).IsRequired();
            builder.Property(s => s.Title).IsRequired().HasMaxLength(50);
            builder.Property(s=>s.Info).IsRequired().HasMaxLength(250);
            builder.Property(s => s.Info2).IsRequired().HasMaxLength(150);
            builder.Property(s => s.IsDeleted).HasDefaultValue(false);
            builder.Property(s => s.CreatedAt).HasDefaultValueSql("GETUTCDATE()");

        }
    }
}
