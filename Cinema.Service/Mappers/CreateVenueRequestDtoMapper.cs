using Cinema.Data.Entities;
using Cinema.Service.DTOs.Request;

namespace Cinema.Service.Mappers;

public static class CreateVenueRequestDtoMapper
{
    public static Venue ToEntity(this CreateVenueRequestDto venueDto) => new(
        venueDto.Name,
        true,
        venueDto.Address?.ZipCode,
        venueDto.Address?.State,
        venueDto.Address?.City,
        venueDto.Address?.Street,
        venueDto.Address?.Number,
        venueDto.Address?.Complement);
}