using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class MigrationRequiredBaseModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cuenta",
                keyColumn: "Id",
                keyValue: 1L,
                column: "FechaCreado",
                value: new DateTime(2023, 2, 21, 8, 59, 5, 199, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "Cuenta",
                keyColumn: "Id",
                keyValue: 2L,
                column: "FechaCreado",
                value: new DateTime(2023, 2, 21, 8, 59, 5, 199, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Cuenta",
                keyColumn: "Id",
                keyValue: 3L,
                column: "FechaCreado",
                value: new DateTime(2023, 2, 21, 8, 59, 5, 199, DateTimeKind.Local).AddTicks(3905));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cuenta",
                keyColumn: "Id",
                keyValue: 1L,
                column: "FechaCreado",
                value: new DateTime(2023, 2, 20, 14, 34, 10, 749, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "Cuenta",
                keyColumn: "Id",
                keyValue: 2L,
                column: "FechaCreado",
                value: new DateTime(2023, 2, 20, 14, 34, 10, 749, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "Cuenta",
                keyColumn: "Id",
                keyValue: 3L,
                column: "FechaCreado",
                value: new DateTime(2023, 2, 20, 14, 34, 10, 749, DateTimeKind.Local).AddTicks(2571));
        }
    }
}
