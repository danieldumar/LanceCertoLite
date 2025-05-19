using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanceCertoLite.Migrations
{
    /// <inheritdoc />
    public partial class CamposExtrasLeilao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomeDono",
                table: "Leiloes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeImovel",
                table: "Leiloes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "ValorInicial",
                table: "Leiloes",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeDono",
                table: "Leiloes");

            migrationBuilder.DropColumn(
                name: "NomeImovel",
                table: "Leiloes");

            migrationBuilder.DropColumn(
                name: "ValorInicial",
                table: "Leiloes");
        }
    }
}
