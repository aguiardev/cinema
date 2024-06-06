using Cinema.Data.Entities;

namespace Cinema.Data.Repositories.Read.Interfaces;
public interface IVenueReadRepository
{
    Task<IList<Venue>> GetAllAsync(bool? isActive);
    Task<Venue?> GetByIdAsync(int venueId);
}