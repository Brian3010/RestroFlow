using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestroFlowAPI.Migrations.RestroFlowDb
{
  /// <inheritdoc />
  public partial class AdjusttableInventoryAlerts : Migration
  {
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder) {
      migrationBuilder.AlterColumn<int>(
            name: "AlertType",
            table: "InventoryAlerts",
            nullable: false,
            oldClrType: typeof(string),
            oldType: "nvarchar(max)");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder) {
      migrationBuilder.AlterColumn<string>(
            name: "YourField",
            table: "InventoryAlerts",
            nullable: false,
            oldClrType: typeof(int),
            oldType: "int");
    }
  }
}
