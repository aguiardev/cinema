namespace Cinema.Service.DTOs.Response;

public record GetAllVenuesResponseDto(
    int VenueId,
    string? Name,
    bool Active,
    GetAllVenuesAddressResponseDto Address);

public record GetAllVenuesAddressResponseDto(
    string? ZipCode,
    string? State,
    string? City,
    string? Street,
    string? Number,
    string? Complement);