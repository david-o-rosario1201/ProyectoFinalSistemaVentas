using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SistemaVentas.Migrations
{
    /// <inheritdoc />
    public partial class TiposTelefono : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoTelefonos",
                columns: table => new
                {
                    TipoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTelefonos", x => x.TipoId);
                });

            migrationBuilder.InsertData(
                table: "TipoTelefonos",
                columns: new[] { "TipoId", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Teléfono" },
                    { 2, "Celular" },
                    { 3, "Oficina" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipoTelefonos");
        }
    }
}
