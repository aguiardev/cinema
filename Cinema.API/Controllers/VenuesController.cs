using Asp.Versioning;
using Cinema.API.Extensions;
using Cinema.Service.DTOs.Request;
using Cinema.Service.DTOs.Response;
using Cinema.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.API.Controllers;
[ApiController]
[ApiVersion("1")]
[Route("api/v{version:apiVersion}/[controller]")]
public class VenuesController(ILogger<VenuesController> logger, IVenueService venueService) : ControllerBase
{
    private readonly ILogger<VenuesController> _logger = logger;
    private readonly IVenueService _venueService = venueService;

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateVenueRequestDto request)
    {
        var venueId = await _venueService.CreateAsync(request);

        return venueId > 0
            ? CreatedAtAction(
                nameof(GetById),
                new { id = venueId },
                ApiResponseExtension<int>.CreateResponse(venueId))
            : BadRequest();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] bool? isActive)
    {
        var venues = await _venueService.GetAllAsync(isActive);

        return venues.Any()
            ? Ok(ApiResponseExtension<IReadOnlyCollection<GetAllVenuesResponseDto>>
                .CreateResponse(venues))
            : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var venues = await _venueService.GetByIdAsync(id);

        return venues is null
            ? NotFound()
            : Ok(ApiResponseExtension<GetVenueByIdResponseDto>.CreateResponse(venues));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] UpdateVenueRequestDto request)
    {
        var venue = await _venueService.GetByIdAsync(id);

        if (venue is null)
            return NotFound();

        await _venueService.UpdateAsync(id, request);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var venue = await _venueService.GetByIdAsync(id);

        if (venue is null)
            return NotFound();

        await _venueService.DeleteAsync(id);

        return NoContent();
    }
}