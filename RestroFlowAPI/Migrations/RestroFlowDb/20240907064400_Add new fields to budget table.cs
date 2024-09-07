using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestroFlowAPI.Migrations.RestroFlowDb
{
    /// <inheritdoc />
    public partial class Addnewfieldstobudgettable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BudgetTimePeriod",
                table: "Budgets");

            migrationBuilder.AddColumn<DateTime>(
                name: "BudgetEndDate",
                table: "Budgets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "BudgetStartDate",
                table: "Budgets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BudgetEndDate",
                table: "Budgets");

            migrationBuilder.DropColumn(
                name: "BudgetStartDate",
                table: "Budgets");

            migrationBuilder.AddColumn<string>(
                name: "BudgetTimePeriod",
                table: "Budgets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
