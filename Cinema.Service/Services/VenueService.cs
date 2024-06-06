using Cinema.Data.Repositories.Read.Interfaces;
using Cinema.Data.Repositories.Write.Interfaces;
using Cinema.Service.DTOs.Request;
using Cinema.Service.DTOs.Response;
using Cinema.Service.Mappers;
using Cinema.Service.Services.Interfaces;

namespace Cinema.Service.Services;
public class VenueService(
    IVenueReadRepository readRepository,
    IVenueWriteRepository writeRepository) : IVenueService
{
    private readonly IVenueReadRepository _readRepository = readRepository;
    private readonly IVenueWriteRepository _writeRepository = writeRepository;

    public async Task<int> CreateAsync(CreateVenueRequestDto venuetDto)
        => await _writeRepository.CreateAsync(venuetDto.ToEntity());

    public async Task DeleteAsync(int id)
        => await _writeRepository.DeleteAsync(id);

    public async Task<IReadOnlyCollection<GetAllVenuesResponseDto>> GetAllAsync(bool? isActive)
        => (await _readRepository.GetAllAsync(isActive)).ToGetAllVenuesResponseListDto();

    public async Task<GetVenueByIdResponseDto?> GetByIdAsync(int venueId)
        => (await _readRepository.GetByIdAsync(venueId))?.ToGetVenueByIdResponseDto();

    public async Task UpdateAsync(int venueId, UpdateVenueRequestDto venueDto)
    {
        var existingVenue = await _readRepository.GetByIdAsync(venueId);

        var updatedVenue = venueDto.ToEntity(existingVenue);

        await _writeRepository.UpdateAsync(updatedVenue);
    }
}