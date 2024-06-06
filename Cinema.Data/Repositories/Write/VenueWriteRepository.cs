using Cinema.Data.Contexts;
using Cinema.Data.Entities;
using Cinema.Data.Repositories.Write.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Data.Repositories.Write;
public class VenueWriteRepository(WriteContext context) : IVenueWriteRepository
{
    private readonly WriteContext _context = context;

    public async Task<int> CreateAsync(Venue venue)
    {
        await _context.AddAsync(venue);
        _ = await _context.SaveChangesAsync();

        return venue.VenueId;
    }

    public async Task DeleteAsync(int venueId)
    {
        var venue = await _context.Venues
            .FirstAsync(f => f.VenueId == venueId);

        venue.Active = false;

        _ = await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Venue venue)
    {
        _context.Venues.Update(venue);
        _ = await _context.SaveChangesAsync();
    }
}