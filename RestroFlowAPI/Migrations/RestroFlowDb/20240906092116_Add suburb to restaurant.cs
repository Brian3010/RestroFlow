using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestroFlowAPI.Migrations.RestroFlowDb
{
    /// <inheritdoc />
    public partial class Addsuburbtorestaurant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Suburb",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Suburb",
                table: "Restaurants");
        }
    }
}
