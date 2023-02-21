using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class MigracionAddColumnTransferenciaModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Motivo",
                table: "Transferencia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Cuenta",
                keyColumn: "Id",
                keyValue: 1L,
                column: "FechaCreado",
                value: new DateTime(2023, 2, 20, 11, 58, 6, 718, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Cuenta",
                keyColumn: "Id",
                keyValue: 2L,
                column: "FechaCreado",
                value: new DateTime(2023, 2, 20, 11, 58, 6, 718, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Cuenta",
                keyColumn: "Id",
                keyValue: 3L,
                column: "FechaCreado",
                value: new DateTime(2023, 2, 20, 11, 58, 6, 718, DateTimeKind.Local).AddTicks(8958));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Motivo",
                table: "Transferencia");

            migrationBuilder.UpdateData(
                table: "Cuenta",
                keyColumn: "Id",
                keyValue: 1L,
                column: "FechaCreado",
                value: new DateTime(2023, 2, 20, 11, 36, 31, 611, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Cuenta",
                keyColumn: "Id",
                keyValue: 2L,
                column: "FechaCreado",
                value: new DateTime(2023, 2, 20, 11, 36, 31, 611, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "Cuenta",
                keyColumn: "Id",
                keyValue: 3L,
                column: "FechaCreado",
                value: new DateTime(2023, 2, 20, 11, 36, 31, 611, DateTimeKind.Local).AddTicks(5786));
        }
    }
}
