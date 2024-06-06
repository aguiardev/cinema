using Cinema.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.Data.Contexts.Configuration;
public class VenueConfiguration : IEntityTypeConfiguration<Venue>
{
    public void Configure(EntityTypeBuilder<Venue> builder)
    {
        builder.ToTable("Venues").HasKey(b => b.VenueId);

        builder
            .Property(v => v.Name)
            .IsRequired()
            .HasMaxLength(150);

        builder
            .Property(v => v.Active)
            .IsRequired();

        builder
            .Property(v => v.ZipCode)
            .IsRequired()
            .HasMaxLength(8);

        builder
            .Property(v => v.State)
            .IsRequired()
            .HasMaxLength(2);

        builder
            .Property(v => v.City)
            .IsRequired()
            .HasMaxLength(150);

        builder
            .Property(v => v.Street)
            .IsRequired()
            .HasMaxLength(250);

        builder
            .Property(v => v.Number);

        builder
            .Property(v => v.Complement)
            .HasMaxLength(150);
    }
}