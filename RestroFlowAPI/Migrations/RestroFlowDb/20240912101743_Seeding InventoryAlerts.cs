using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestroFlowAPI.Migrations.RestroFlowDb
{
    /// <inheritdoc />
    public partial class SeedingInventoryAlerts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "InventoryAlerts",
                columns: new[] { "Id", "AlertType", "CreatedAt", "RestaurantItemId", "Threshold", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2187d49e-ec70-4246-bbe7-d5881625a245"), "Low Stock", new DateTime(2024, 9, 12, 20, 17, 43, 403, DateTimeKind.Local).AddTicks(8277), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), 20f, new DateTime(2024, 9, 12, 20, 17, 43, 403, DateTimeKind.Local).AddTicks(8278) },
                    { new Guid("4014a557-256a-44e4-b2cc-cfd2ddb1da78"), "Low Stock", new DateTime(2024, 9, 12, 20, 17, 43, 403, DateTimeKind.Local).AddTicks(8295), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), 8f, new DateTime(2024, 9, 12, 20, 17, 43, 403, DateTimeKind.Local).AddTicks(8296) },
                    { new Guid("4a0e1948-2623-4158-8236-a183a13ad350"), "Low Stock", new DateTime(2024, 9, 12, 20, 17, 43, 403, DateTimeKind.Local).AddTicks(8286), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), 5f, new DateTime(2024, 9, 12, 20, 17, 43, 403, DateTimeKind.Local).AddTicks(8288) },
                    { new Guid("5d47ee2f-5b63-411c-8b32-897ad315039d"), "Low Stock", new DateTime(2024, 9, 12, 20, 17, 43, 403, DateTimeKind.Local).AddTicks(8315), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), 9f, new DateTime(2024, 9, 12, 20, 17, 43, 403, DateTimeKind.Local).AddTicks(8316) },
                    { new Guid("63cd57fa-415e-4eff-b30c-2b0a25db8f92"), "Low Stock", new DateTime(2024, 9, 12, 20, 17, 43, 403, DateTimeKind.Local).AddTicks(8227), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), 20f, new DateTime(2024, 9, 12, 20, 17, 43, 403, DateTimeKind.Local).AddTicks(8263) },
                    { new Guid("72486e37-1b15-4464-bfb4-187eb7cddefe"), "Low Stock", new DateTime(2024, 9, 12, 20, 17, 43, 403, DateTimeKind.Local).AddTicks(8281), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), 9f, new DateTime(2024, 9, 12, 20, 17, 43, 403, DateTimeKind.Local).AddTicks(8283) },
                    { new Guid("79612fcd-48fe-4ef5-886d-24e04f5e3787"), "Low Stock", new DateTime(2024, 9, 12, 20, 17, 43, 403, DateTimeKind.Local).AddTicks(8299), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), 20f, new DateTime(2024, 9, 12, 20, 17, 43, 403, DateTimeKind.Local).AddTicks(8301) },
                    { new Guid("8a9e281a-b5d6-4ff7-91ec-fe69df7c5d18"), "Low Stock", new DateTime(2024, 9, 12, 20, 17, 43, 403, DateTimeKind.Local).AddTicks(8303), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), 3f, new DateTime(2024, 9, 12, 20, 17, 43, 403, DateTimeKind.Local).AddTicks(8305) },
                    { new Guid("a56c8525-610b-45e0-9826-502a9cf4dea6"), "Low Stock", new DateTime(2024, 9, 12, 20, 17, 43, 403, DateTimeKind.Local).AddTicks(8269), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), 9f, new DateTime(2024, 9, 12, 20, 17, 43, 403, DateTimeKind.Local).AddTicks(8270) },
                    { new Guid("bf718cca-b3b4-4343-a3f5-d09ca7edc2d1"), "Low Stock", new DateTime(2024, 9, 12, 20, 17, 43, 403, DateTimeKind.Local).AddTicks(8309), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), 25f, new DateTime(2024, 9, 12, 20, 17, 43, 403, DateTimeKind.Local).AddTicks(8311) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InventoryAlerts",
                keyColumn: "Id",
                keyValue: new Guid("2187d49e-ec70-4246-bbe7-d5881625a245"));

            migrationBuilder.DeleteData(
                table: "InventoryAlerts",
                keyColumn: "Id",
                keyValue: new Guid("4014a557-256a-44e4-b2cc-cfd2ddb1da78"));

            migrationBuilder.DeleteData(
                table: "InventoryAlerts",
                keyColumn: "Id",
                keyValue: new Guid("4a0e1948-2623-4158-8236-a183a13ad350"));

            migrationBuilder.DeleteData(
                table: "InventoryAlerts",
                keyColumn: "Id",
                keyValue: new Guid("5d47ee2f-5b63-411c-8b32-897ad315039d"));

            migrationBuilder.DeleteData(
                table: "InventoryAlerts",
                keyColumn: "Id",
                keyValue: new Guid("63cd57fa-415e-4eff-b30c-2b0a25db8f92"));

            migrationBuilder.DeleteData(
                table: "InventoryAlerts",
                keyColumn: "Id",
                keyValue: new Guid("72486e37-1b15-4464-bfb4-187eb7cddefe"));

            migrationBuilder.DeleteData(
                table: "InventoryAlerts",
                keyColumn: "Id",
                keyValue: new Guid("79612fcd-48fe-4ef5-886d-24e04f5e3787"));

            migrationBuilder.DeleteData(
                table: "InventoryAlerts",
                keyColumn: "Id",
                keyValue: new Guid("8a9e281a-b5d6-4ff7-91ec-fe69df7c5d18"));

            migrationBuilder.DeleteData(
                table: "InventoryAlerts",
                keyColumn: "Id",
                keyValue: new Guid("a56c8525-610b-45e0-9826-502a9cf4dea6"));

            migrationBuilder.DeleteData(
                table: "InventoryAlerts",
                keyColumn: "Id",
                keyValue: new Guid("bf718cca-b3b4-4343-a3f5-d09ca7edc2d1"));
        }
    }
}
