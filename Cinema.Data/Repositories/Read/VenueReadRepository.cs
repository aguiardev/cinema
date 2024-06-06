using Cinema.Data.Contexts;
using Cinema.Data.Entities;
using Cinema.Data.Repositories.Read.Interfaces;
using Dapper;

namespace Cinema.Data.Repositories.Read;
public class VenueReadRepository(ReadContext readContext) : IVenueReadRepository
{
    private string SQL_GET_ALL = "select * from Venues";
    private string SQL_GET_BY_ID = "select * from Venues where VenueId = @VenueId";

    private readonly ReadContext _readContext = readContext;

    public async Task<IList<Venue>> GetAllAsync(bool? isActive)
    {
        if (isActive.HasValue)
        {
            SQL_GET_ALL += " WHERE Active = @IsActive";
        }

        var venues = await _readContext.Connection
            .QueryAsync<Venue>(SQL_GET_ALL, new { IsActive = isActive.GetValueOrDefault(true) });

        return venues.AsList();
    }

    public async Task<Venue?> GetByIdAsync(int venueId)
    {
        var parameters = new
        {
            VenueId = venueId
        };

        var venues = await _readContext.Connection
            .QueryFirstOrDefaultAsync<Venue>(SQL_GET_BY_ID, parameters);

        return venues;
    }
}