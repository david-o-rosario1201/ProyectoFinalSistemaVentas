﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SistemaVentas.Migrations
{
    /// <inheritdoc />
    public partial class TiposContribuyente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TiposContribuyente",
                columns: table => new
                {
                    TipoContribuyenteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposContribuyente", x => x.TipoContribuyenteId);
                });

            migrationBuilder.InsertData(
                table: "TiposContribuyente",
                columns: new[] { "TipoContribuyenteId", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Persona Física" },
                    { 2, "Persona Jurídica" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TiposContribuyente");
        }
    }
}
