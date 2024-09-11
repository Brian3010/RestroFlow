using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestroFlowAPI.Migrations.RestroFlowDb
{
    /// <inheritdoc />
    public partial class Modifytables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AverageOrderValue",
                table: "SaleReports");

            migrationBuilder.DropColumn(
                name: "SalesByTimePeriod",
                table: "SaleReports");

            migrationBuilder.AddColumn<int>(
                name: "PaymentMethod",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(9930), new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(9904), new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("51a801ff-89b7-4663-a308-b0b577018e14"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(9968), new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(9976), new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(9949), new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(9983), new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(9956), new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(9403), new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(9548) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(9937), new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(9962), new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: new Guid("114288a7-a300-42c6-8578-5f52df5ce147"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(5866), new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(5872), new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: new Guid("cf762d80-3731-4d9d-af92-b77f99676005"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(2325), new DateTime(2024, 9, 11, 20, 13, 6, 580, DateTimeKind.Local).AddTicks(5796) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "Sales");

            migrationBuilder.AddColumn<decimal>(
                name: "AverageOrderValue",
                table: "SaleReports",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "SalesByTimePeriod",
                table: "SaleReports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5000), new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(4992), new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("51a801ff-89b7-4663-a308-b0b577018e14"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5026), new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5075), new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5012), new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5013) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5081), new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5017), new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(4562), new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5004), new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5021), new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: new Guid("114288a7-a300-42c6-8578-5f52df5ce147"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(2041), new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(2046), new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: new Guid("cf762d80-3731-4d9d-af92-b77f99676005"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(1549), new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(2022) });
        }
    }
}
