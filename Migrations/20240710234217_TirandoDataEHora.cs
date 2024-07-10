using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barbearia.API.Migrations
{
    /// <inheritdoc />
    public partial class TirandoDataEHora : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataHora",
                table: "Agendamentos",
                newName: "Data");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Agendamentos",
                newName: "DataHora");
        }
    }
}
