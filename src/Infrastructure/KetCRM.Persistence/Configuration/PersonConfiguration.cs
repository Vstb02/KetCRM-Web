using KetCRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KetCRM.Persistence.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Id).IsUnique();
            builder.Property(e => e.BirthDate).HasColumnType("date");
            builder.Property(e => e.Comment).HasMaxLength(500);
            builder.Property(e => e.EmailAddress).HasMaxLength(50);
            builder.Property(e => e.Gender).HasMaxLength(50);
            builder.Property(e => e.InsuranceNumber).HasMaxLength(50);
            builder.Property(e => e.Name).HasMaxLength(50);
            builder.Property(e => e.PassportDate).HasColumnType("date");
            builder.Property(e => e.PassportNumber).HasMaxLength(10);
            builder.Property(e => e.PassportPlace).HasMaxLength(100);
            builder.Property(e => e.PassportSeries).HasMaxLength(10);
            builder.Property(e => e.Patronymic).HasMaxLength(50);
            builder.Property(e => e.PhoneNumber).HasMaxLength(11);
            builder.Property(e => e.Photo).HasColumnType("image");
            builder.Property(e => e.Snils)
                .HasMaxLength(50)
                .HasColumnName("SNILS");
            builder.Property(e => e.Surname).HasMaxLength(50);
        }
    }
}
