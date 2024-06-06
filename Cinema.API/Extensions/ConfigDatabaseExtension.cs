using Cinema.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Cinema.API.Extensions;

public static class ConfigDatabaseExtension
{
    public static IServiceCollection AddWriteDb(
        this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        if (string.IsNullOrEmpty(connectionString))
            throw new ArgumentException("Sqlite connection string is null!");

        services.AddDbContext<WriteContext>(opt =>
            opt.UseSqlite(connectionString));

        return services;
    }

    public static IServiceCollection AddReadDb(
        this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        if (string.IsNullOrEmpty(connectionString))
            throw new ArgumentException("Sqlite connection string is null!");

        services.AddTransient<ReadContext>(provider =>
            new ReadContext(connectionString));

        return services;
    }
}