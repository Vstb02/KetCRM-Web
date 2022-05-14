using KetCRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Persistence.Configuration
{
    public class SchoolTypeConfiguration : IEntityTypeConfiguration<SchoolType>
    {
        public void Configure(EntityTypeBuilder<SchoolType> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Id).IsUnique();
            builder.Property(e => e.Name).HasMaxLength(100);
        }
    }
}
