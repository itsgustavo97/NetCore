using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class MigrationCambioDataUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cuenta",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Cuenta",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Cuenta",
                keyColumn: "Id",
                keyValue: 3L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cuenta",
                columns: new[] { "Id", "Borrado", "FechaCreado", "FechaModificado", "NumeroCuenta", "Saldo", "TipoCuenta" },
                values: new object[] { 1L, false, new DateTime(2023, 2, 21, 8, 59, 5, 199, DateTimeKind.Local).AddTicks(3888), null, 1L, 900m, 1 });

            migrationBuilder.InsertData(
                table: "Cuenta",
                columns: new[] { "Id", "Borrado", "FechaCreado", "FechaModificado", "NumeroCuenta", "Saldo", "TipoCuenta" },
                values: new object[] { 2L, false, new DateTime(2023, 2, 21, 8, 59, 5, 199, DateTimeKind.Local).AddTicks(3904), null, 1L, 900m, 1 });

            migrationBuilder.InsertData(
                table: "Cuenta",
                columns: new[] { "Id", "Borrado", "FechaCreado", "FechaModificado", "NumeroCuenta", "Saldo", "TipoCuenta" },
                values: new object[] { 3L, false, new DateTime(2023, 2, 21, 8, 59, 5, 199, DateTimeKind.Local).AddTicks(3905), null, 1L, 900m, 1 });
        }
    }
}
