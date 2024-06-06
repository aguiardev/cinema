namespace Cinema.Service.DTOs.Request;

public record CreateVenueRequestDto(
    string? Name,
    CreateVenueAddressRequestDto? Address);

public record CreateVenueAddressRequestDto(
    string? ZipCode,
    string? State,
    string? City,
    string? Street,
    string? Number,
    string? Complement);