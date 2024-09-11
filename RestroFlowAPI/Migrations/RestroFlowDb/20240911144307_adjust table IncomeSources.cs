using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestroFlowAPI.Migrations.RestroFlowDb
{
    /// <inheritdoc />
    public partial class adjusttableIncomeSources : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_IncomeSources_PaymentMethodId",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IncomeSources",
                table: "IncomeSources");

            migrationBuilder.RenameTable(
                name: "IncomeSources",
                newName: "PaymentMethods");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentMethods",
                table: "PaymentMethods",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 0, 43, 7, 163, DateTimeKind.Local).AddTicks(858), new DateTime(2024, 9, 12, 0, 43, 7, 163, DateTimeKind.Local).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 0, 43, 7, 163, DateTimeKind.Local).AddTicks(852), new DateTime(2024, 9, 12, 0, 43, 7, 163, DateTimeKind.Local).AddTicks(855) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 0, 43, 7, 163, DateTimeKind.Local).AddTicks(486), new DateTime(2024, 9, 12, 0, 43, 7, 163, DateTimeKind.Local).AddTicks(615) });

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_PaymentMethods_PaymentMethodId",
                table: "Sales",
                column: "PaymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_PaymentMethods_PaymentMethodId",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentMethods",
                table: "PaymentMethods");

            migrationBuilder.RenameTable(
                name: "PaymentMethods",
                newName: "IncomeSources");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IncomeSources",
                table: "IncomeSources",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "IncomeSources",
                keyColumn: "Id",
                keyValue: new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 0, 41, 1, 984, DateTimeKind.Local).AddTicks(450), new DateTime(2024, 9, 12, 0, 41, 1, 984, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "IncomeSources",
                keyColumn: "Id",
                keyValue: new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 0, 41, 1, 984, DateTimeKind.Local).AddTicks(443), new DateTime(2024, 9, 12, 0, 41, 1, 984, DateTimeKind.Local).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "IncomeSources",
                keyColumn: "Id",
                keyValue: new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 0, 41, 1, 984, DateTimeKind.Local).AddTicks(72), new DateTime(2024, 9, 12, 0, 41, 1, 984, DateTimeKind.Local).AddTicks(203) });

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_IncomeSources_PaymentMethodId",
                table: "Sales",
                column: "PaymentMethodId",
                principalTable: "IncomeSources",
                principalColumn: "Id");
        }
    }
}
