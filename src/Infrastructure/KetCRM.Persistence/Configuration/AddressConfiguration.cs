using KetCRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KetCRM.Persistence.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Id).IsUnique();
            builder.Property(e => e.Country).HasMaxLength(50);
            builder.Property(e => e.Region).HasMaxLength(50);
            builder.Property(e => e.City).HasMaxLength(50);
            builder.Property(e => e.Street).HasMaxLength(50);
            builder.Property(e => e.House).HasMaxLength(50);
            builder.Property(e => e.Flat).HasMaxLength(50);
        }
    }
}
