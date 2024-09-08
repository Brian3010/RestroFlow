using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestroFlowAPI.Migrations.RestroFlowDb
{
    /// <inheritdoc />
    public partial class Testingseedingrestauranttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Address", "City", "CreatedAt", "Name", "Suburb", "UpdatedAt" },
                values: new object[] { new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), "840 Glenferrie Rd, Hawthorn VIC 3122", "Mebourne", new DateTime(2024, 1, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), "Gami Chicken and Beer", "Hawthorn", new DateTime(2024, 1, 1, 14, 30, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"));
        }
    }
}
