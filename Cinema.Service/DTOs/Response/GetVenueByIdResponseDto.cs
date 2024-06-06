namespace Cinema.Service.DTOs.Response;

public record GetVenueByIdResponseDto(
    int VenueId,
    string? Name,
    bool Active,
    GetVenueByIdAddressResponseDto? Address);
    
public record GetVenueByIdAddressResponseDto(
    string? ZipCode,
    string? State,
    string? City,
    string? Street,
    string? Number,
    string? Complement);