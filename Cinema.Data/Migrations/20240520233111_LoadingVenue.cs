using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinema.Data.Migrations
{
    /// <inheritdoc />
    public partial class LoadingVenue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder) => migrationBuilder.Sql(
            "INSERT INTO Venues (Name, Active, ZipCode, State, City, Street, Number, Complement) VALUES" +
            "('Cinema da Cidade', 1, '12345-678', 'São Paulo', 'São Paulo', 'Rua Principal', '123', 'Apto 1')," +
            "('Cineplex', 1, '54321-876', 'Rio de Janeiro', 'Rio de Janeiro', 'Avenida Central', '456', 'Sala 2')," +
            "('Cinestar', 0, '98765-432', 'Minas Gerais', 'Belo Horizonte', 'Rua das Palmeiras', '789', 'Conjunto 3')," +
            "('CineCenter', 1, '13579-246', 'Paraná', 'Curitiba', 'Avenida do Bosque', '1011', 'Andar 4')," +
            "('MegaCinema', 1, '86420-159', 'Santa Catarina', 'Florianópolis', 'Rua das Flores', '1213', 'Bloco 5')");

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
            => migrationBuilder.Sql("DELETE FROM Venues");
    }
}
