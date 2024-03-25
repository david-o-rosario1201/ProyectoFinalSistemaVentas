using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaVentas.Migrations
{
    /// <inheritdoc />
    public partial class Categorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "Categorias",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 10,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "Categorias");
        }
    }
}
