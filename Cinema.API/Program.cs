using Asp.Versioning;
using Cinema.API.Extensions;
using Cinema.Data.Repositories.Read;
using Cinema.Data.Repositories.Read.Interfaces;
using Cinema.Data.Repositories.Write;
using Cinema.Data.Repositories.Write.Interfaces;
using Cinema.Service.Services;
using Cinema.Service.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Connections
builder.Services.AddReadDb(builder.Configuration);
builder.Services.AddWriteDb(builder.Configuration);

// Repositories
builder.Services.AddScoped<IVenueReadRepository, VenueReadRepository>();
builder.Services.AddScoped<IVenueWriteRepository, VenueWriteRepository>();

// Services
builder.Services.AddScoped<IVenueService, VenueService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ReportApiVersions = true;
})
.AddApiExplorer(options =>
{
    options.GroupNameFormat = "'v'VVV";
    options.SubstituteApiVersionInUrl = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();