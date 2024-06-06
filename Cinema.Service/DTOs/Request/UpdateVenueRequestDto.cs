namespace Cinema.Service.DTOs.Request;

public record UpdateVenueRequestDto(
    string? Name,
    UpdateVenueAddressRequestDto? Address);

public record UpdateVenueAddressRequestDto(
    string? ZipCode,
    string? State,
    string? City,
    string? Street,
    string? Number,
    string? Complement);