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
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Id).IsUnique();
            builder.Property(e => e.GraduatedSchool).HasMaxLength(100);
            builder.Property(e => e.OlimpiadeWinner).HasMaxLength(100);
            builder.Property(e => e.OnAbudget).HasColumnName("OnABudget");
            builder.Property(e => e.PassCardNumber).HasMaxLength(50);
            builder.Property(e => e.SchoolCertificateNumber).HasMaxLength(50);
            builder.Property(e => e.StudentCardNumber).HasMaxLength(50);
            builder.Property(e => e.StudentCerteficateNumber).HasMaxLength(50);
            builder.Property(e => e.StudentRecordBookNumber).HasMaxLength(50);
        }
    }
}
