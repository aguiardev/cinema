using Cinema.Service.DTOs.Request;
using Cinema.Service.DTOs.Response;

namespace Cinema.Service.Services.Interfaces;
public interface IVenueService
{
    Task<IReadOnlyCollection<GetAllVenuesResponseDto>> GetAllAsync(bool? isActive);
    Task<GetVenueByIdResponseDto?> GetByIdAsync(int venueId);
    Task<int> CreateAsync(CreateVenueRequestDto venueDto);
    Task UpdateAsync(int venueId, UpdateVenueRequestDto venueDto);
    Task DeleteAsync(int venueId);
}