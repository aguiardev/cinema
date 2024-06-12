using Cinema.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.Data.Contexts.Configuration;
public class VenueOperatingHourConfiguration : IEntityTypeConfiguration<VenueOperatingHour>
{
    public void Configure(EntityTypeBuilder<VenueOperatingHour> builder)
    {
        builder.ToTable("VenueOperatingHours");

        builder.HasKey(voh => voh.VenueOperatingHoursId);

        builder.Property(voh => voh.FirstSessionTime)
            .IsRequired()
            .HasConversion(
                v => v.ToString("HH:mm:ss"), // Converter para string ao salvar
                v => TimeOnly.Parse(v) // Converter para DateTime ao ler
            );

        builder.Property(voh => voh.LastSessionTime)
            .IsRequired()
            .HasConversion(
                v => v.ToString("HH:mm:ss"), // Converter para string ao salvar
                v => TimeOnly.Parse(v) // Converter para DateTime ao ler
            );

        builder.Property(voh => voh.IntervalMinutes).IsRequired();
        builder.Property(voh => voh.Type).IsRequired();
        builder.Property(voh => voh.Value).IsRequired();

        builder.HasOne(voh => voh.Venue)
            .WithMany(v => v.OperatingHours) // Assuming that Venue has a collection of VenueOperatingHours
            .HasForeignKey(voh => voh.VenueId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
