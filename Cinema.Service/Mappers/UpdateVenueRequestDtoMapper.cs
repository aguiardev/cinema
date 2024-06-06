using Cinema.Data.Entities;
using Cinema.Service.DTOs.Request;

namespace Cinema.Service.Mappers;
public static class UpdateVenueRequestDtoMapper
{
    public static Venue ToEntity(this UpdateVenueRequestDto dto, Venue existingVenue)
    {
        existingVenue.Name = dto.Name;
        existingVenue.ZipCode = dto.Address.ZipCode;
        existingVenue.State = dto.Address.State;
        existingVenue.City = dto.Address.City;
        existingVenue.Street = dto.Address.Street;
        existingVenue.Number = dto.Address.Number;
        existingVenue.Complement = dto.Address.Complement;

        return existingVenue;
    }
}