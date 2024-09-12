using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestroFlowAPI.Migrations.RestroFlowDb
{
  /// <inheritdoc />
  public partial class AdjusttableBudget : Migration
  {
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder) {

      migrationBuilder.AlterColumn<string>(
          name: "BudgetCategory",
          table: "Budgets",
          type: "nvarchar(max)",
          nullable: false,
          oldClrType: typeof(int),
          oldType: "int");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder) {
      migrationBuilder.AlterColumn<int>(
          name: "BudgetCategory",
          table: "Budgets",
          type: "int",
          nullable: false,
          oldClrType: typeof(string),
          oldType: "nvarchar(max)");


    }
  }
}
