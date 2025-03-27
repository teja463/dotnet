using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreWebAppMvc.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SerialNumbers",
                columns: new[] { "Id", "ItemId", "Name" },
                values: new object[] { 1, 1, "HDD1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
