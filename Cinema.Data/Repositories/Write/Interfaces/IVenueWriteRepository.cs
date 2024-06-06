using Cinema.Data.Entities;

namespace Cinema.Data.Repositories.Write.Interfaces;
public interface IVenueWriteRepository
{
    Task<int> CreateAsync(Venue venue);
    Task UpdateAsync(Venue venue);
    Task DeleteAsync(int venueId);
}