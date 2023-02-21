using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class MigracionModifiedColumnCuenta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Motivo",
                table: "Transferencia",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Motivo",
                table: "Transferencia",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

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
    }
}
