using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestroFlowAPI.Migrations.RestroFlowDb
{
    /// <inheritdoc />
    public partial class changetablenames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "IncomeSources",
                columns: new[] { "Id", "CreatedAt", "IncomeType", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(1464), "Take-away", new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(1465) },
                    { new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(1457), "Delivery", new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(1461) },
                    { new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(1087), "Dine-in", new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(1258) }
                });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(518), new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(508), new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("51a801ff-89b7-4663-a308-b0b577018e14"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(599), new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(607), new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(579), new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(614), new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(586), new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(588) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 39, 55, 293, DateTimeKind.Local).AddTicks(9996), new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(524), new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(592), new DateTime(2024, 9, 11, 23, 39, 55, 294, DateTimeKind.Local).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: new Guid("114288a7-a300-42c6-8578-5f52df5ce147"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 39, 55, 293, DateTimeKind.Local).AddTicks(7604), new DateTime(2024, 9, 11, 23, 39, 55, 293, DateTimeKind.Local).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 39, 55, 293, DateTimeKind.Local).AddTicks(7619), new DateTime(2024, 9, 11, 23, 39, 55, 293, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: new Guid("cf762d80-3731-4d9d-af92-b77f99676005"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 39, 55, 293, DateTimeKind.Local).AddTicks(7017), new DateTime(2024, 9, 11, 23, 39, 55, 293, DateTimeKind.Local).AddTicks(7593) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IncomeSources",
                keyColumn: "Id",
                keyValue: new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"));

            migrationBuilder.DeleteData(
                table: "IncomeSources",
                keyColumn: "Id",
                keyValue: new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"));

            migrationBuilder.DeleteData(
                table: "IncomeSources",
                keyColumn: "Id",
                keyValue: new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"));

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
    }
}
