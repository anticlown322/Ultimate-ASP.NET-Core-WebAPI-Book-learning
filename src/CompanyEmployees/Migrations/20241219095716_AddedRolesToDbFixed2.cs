using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyEmployees.Migrations
{
    /// <inheritdoc />
    public partial class AddedRolesToDbFixed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21990f0c-5ea3-406b-8570-3ab0b2131407");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fb017fa-ebd8-4392-886e-450249d12cc0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ca7cd8d5-05d8-4d5e-8890-45a65e620c9b", null, "Manager", "MANAGER" },
                    { "e44a8b5c-739d-4b64-baf9-501f27a9c20d", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca7cd8d5-05d8-4d5e-8890-45a65e620c9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e44a8b5c-739d-4b64-baf9-501f27a9c20d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "21990f0c-5ea3-406b-8570-3ab0b2131407", null, "Manager", "MANAGER" },
                    { "2fb017fa-ebd8-4392-886e-450249d12cc0", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
