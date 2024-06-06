using Cinema.Data.Entities;
using Cinema.Service.DTOs.Response;

namespace Cinema.Service.Mappers;
public static class GetVenueByIdResponseDtoMapper
{
    public static GetVenueByIdResponseDto ToGetVenueByIdResponseDto(this Venue venue) => new(
        venue.VenueId,
        venue.Name,
        venue.Active,
        new GetVenueByIdAddressResponseDto(
            venue.ZipCode,
            venue.State,
            venue.City,
            venue.Street,
            venue.Number,
            venue.Complement));
}