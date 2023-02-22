using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Security.Migrations
{
    public partial class MigrationCambioDataAspNetUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79ba8e3f-5c28-42cb-a03e-babcfb0b5bd8",
                column: "ConcurrencyStamp",
                value: "0efb5441-c6fa-4196-b0cd-f22e48d6dd1a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c26c17c-ffe7-43ad-a3b3-b6d50ca71a63",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "42ecf357-fc6f-4ada-95a7-f14f96db5059", "Costumer", "COSTUMER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "294d249b-9b57-48c1-9689-11a91abb6447",
                columns: new[] { "ConcurrencyStamp", "Email", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "06e1a6cd-4674-4307-a536-8b9a73dccfe3", "gustavofofo_97@outlook.com", "Adolfo Montes", "gustavofofo_97@outlook.com", "itsadolfo97", "AQAAAAEAACcQAAAAEO9qOrDb7aXjNoFKD3JwH9L9VxiCYonFNM2Rc4+Xvn2byhnkeeThYXxjoyniUeUWrg==", "c386e628-44fb-4e97-a0a8-487dcdb12d17", "itsadolfo97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f284b3fd-f2cf-476e-a9b6-6560689cc48c",
                columns: new[] { "ConcurrencyStamp", "Email", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "707862ea-b937-4c26-8b1c-68e8b04eff37", "gtfofo97@gmail.com", "Gustavo Pineda", "gtfofo97@gmail.com", "itsgustavo97", "AQAAAAEAACcQAAAAENUZHm+WvMbyG8D9caWYPalWLrS6crENX/mXg9q8KF8qH/MCymxxuAXAjFMDHyGtEg==", "c1ba3b43-6f06-43ff-9d66-9e3f37078f3e", "itsgustavo97" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79ba8e3f-5c28-42cb-a03e-babcfb0b5bd8",
                column: "ConcurrencyStamp",
                value: "93986ce3-1133-43bf-b969-cf8db42d5cca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c26c17c-ffe7-43ad-a3b3-b6d50ca71a63",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1cbcedb2-870e-4b01-9d82-10dacd9f760d", "Operator", "OPERATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "294d249b-9b57-48c1-9689-11a91abb6447",
                columns: new[] { "ConcurrencyStamp", "Email", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c0c858a8-6ed2-4ee4-b86f-ad69fe83f251", "juanperez@locahost.com", "Juan", "juanperez@locahost.com", "juanperez", "AQAAAAEAACcQAAAAEGnygiR7mwq8/7vqdtdhXbAtE0j1U2Fhf1EhxuZpOjz//mT7wBE6+9UI+0tVLAjf6w==", "16e09d94-9508-4a4b-816b-c7fac08e6675", "juanperez" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f284b3fd-f2cf-476e-a9b6-6560689cc48c",
                columns: new[] { "ConcurrencyStamp", "Email", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e0affe9c-6ad9-471a-bb33-1fa1c44c6f6d", "admin@locahost.com", "Vaxi", "admin@locahost.com", "vaxidrez", "AQAAAAEAACcQAAAAEEs8QaWRXRcDCinmhGIRBQ3hSYK4Rbl5mnAD0ltUWJpdCxvgjCkoGGu54iH5EU5mkg==", "662f8ac1-a094-4f18-a55c-a972e4b44a9d", "vaxidrez" });
        }
    }
}
