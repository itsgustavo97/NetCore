using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class migracionModelos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cuenta",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroCuenta = table.Column<long>(type: "bigint", nullable: false),
                    TipoCuenta = table.Column<int>(type: "int", nullable: false),
                    Saldo = table.Column<decimal>(type: "decimal(20,8)", nullable: false),
                    Borrado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificado = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuenta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transferencia",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCuentaOrigen = table.Column<long>(type: "bigint", nullable: false),
                    IdCuentaDestino = table.Column<long>(type: "bigint", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(20,8)", nullable: false),
                    Borrado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificado = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transferencia", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cuenta",
                columns: new[] { "Id", "Borrado", "FechaCreado", "FechaModificado", "NumeroCuenta", "Saldo", "TipoCuenta" },
                values: new object[] { 1L, false, new DateTime(2023, 2, 20, 11, 36, 31, 611, DateTimeKind.Local).AddTicks(5775), null, 1L, 900m, 1 });

            migrationBuilder.InsertData(
                table: "Cuenta",
                columns: new[] { "Id", "Borrado", "FechaCreado", "FechaModificado", "NumeroCuenta", "Saldo", "TipoCuenta" },
                values: new object[] { 2L, false, new DateTime(2023, 2, 20, 11, 36, 31, 611, DateTimeKind.Local).AddTicks(5785), null, 1L, 900m, 1 });

            migrationBuilder.InsertData(
                table: "Cuenta",
                columns: new[] { "Id", "Borrado", "FechaCreado", "FechaModificado", "NumeroCuenta", "Saldo", "TipoCuenta" },
                values: new object[] { 3L, false, new DateTime(2023, 2, 20, 11, 36, 31, 611, DateTimeKind.Local).AddTicks(5786), null, 1L, 900m, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuenta");

            migrationBuilder.DropTable(
                name: "Transferencia");
        }
    }
}
