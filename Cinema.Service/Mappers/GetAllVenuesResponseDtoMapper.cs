using Cinema.Data.Entities;
using Cinema.Service.DTOs.Response;
using System.Collections.ObjectModel;

namespace Cinema.Service.Mappers;
public static class GetAllVenuesResponseDtoMapper
{
    public static IReadOnlyCollection<GetAllVenuesResponseDto> ToGetAllVenuesResponseListDto(this IEnumerable<Venue> venues)
        => new ReadOnlyCollection<GetAllVenuesResponseDto>(venues
                .Select(s => new GetAllVenuesResponseDto(
                    s.VenueId,
                    s.Name,
                    s.Active,
                    new GetAllVenuesAddressResponseDto(
                        s.ZipCode,
                        s.State,
                        s.City,
                        s.Street,
                        s.Number,
                        s.Complement))).ToList());
}