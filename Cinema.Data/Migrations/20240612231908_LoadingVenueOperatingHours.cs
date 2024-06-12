using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinema.Data.Migrations
{
    /// <inheritdoc />
    public partial class LoadingVenueOperatingHours : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder) => migrationBuilder.Sql(
            "insert into VenueOperatingHours (VenueId, FirstSessionTime, LastSessionTime, IntervalMinutes, Type, Value) values" +
            "(1, '15:00:00', '22:00:00', 30, 0, null)," +
            "(1, '12:00:00', '22:00:00', 30, 1, '1')," +
            "(1, '12:00:00', '23:59:00', 30, 1, '6')," +
            "(1, '12:00:00', '22:00:00', 30, 2, '2022-04-21')," +
            "(2, '15:00:00', '22:00:00', 30, 0, null)," +
            "(3, '15:00:00', '22:00:00', 30, 0, null)," +
            "(3, '16:00:00', '22:00:00', 30, 1, '4')," +
            "(4, '15:00:00', '22:00:00', 30, 0, null)," +
            "(4, '12:00:00', '23:59:00', 30, 1, '6')," +
            "(5, '15:00:00', '22:00:00', 30, 0, null)");

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
            => migrationBuilder.Sql("DELETE FROM Venues");
    }
}
