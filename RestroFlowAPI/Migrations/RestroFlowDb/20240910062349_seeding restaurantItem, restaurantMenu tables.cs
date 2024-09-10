using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestroFlowAPI.Migrations.RestroFlowDb
{
    /// <inheritdoc />
    public partial class seedingrestaurantItemrestaurantMenutables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(4992), new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(4996) });

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

            migrationBuilder.InsertData(
                table: "RestaurantItems",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "RestaurantId", "SupplierId", "Unit", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5000), null, "Chicken wings", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5001) },
                    { new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5026), null, "Spicy sauce", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5027) },
                    { new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5075), null, "Sweet Chiilies", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5077) },
                    { new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5012), null, "Marinated beef", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion", new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5013) },
                    { new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5081), null, "Wedges", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5082) },
                    { new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5004), null, "Chicken Steak", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5005) },
                    { new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5021), null, "Soy garlic", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(5023) }
                });

            migrationBuilder.InsertData(
                table: "RestaurantMenus",
                columns: new[] { "Id", "Category", "Description", "DishName", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { new Guid("19924c8f-32e0-4c3d-b425-995ed0ddca5a"), "Korean Classics", "Tender slices of marinated beef and ve ies stir-fried with sweet potato noodles in a sweet soy sauce, served with rice and a fresh green salad with Tangerine dressing.", "Beef Bulgogi", 18.5m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("45859bd4-b0bd-4491-8b1b-7c33a940df8a"), "Fried Chicken (boneless)", "A mix of chicken wingettes and drumettes.", "10 Wings", 17m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("6dac4780-fbf3-41f4-8971-b7abdef83a86"), "Sides", "Locally grown cut potato strips coated in Gami signature batter.", "Gami Chips", 6.9m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("d5d66b38-5140-485b-8575-f83d5fae6a5f"), "Korean Classics", "A healthy and delicious Korean rice dish showcasing flavourful vegetables, your preferred protein and a choice of sauce. Topped with a fried egg.", "Korean Classics", 16m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("dd636f75-f510-47eb-bfc8-cf2613defdba"), "Korean Classics", "TA beloved Korean favourite, featuring stir-fried rice cakes, fish cakes, assorted vegetables, and noodles, all coated in a rich and spicy Korean chilli sauce.", "Tteok Bokki", 14.5m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("fc693bcd-807b-4506-a8fd-dc3e31905a81"), "Sides", "5 deep-fried premium handmade dumplings, filled with chunky prawn meat wrapped in thin crispy skin.", "Prawn Mandu", 14.5m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") }
                });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: new Guid("cf762d80-3731-4d9d-af92-b77f99676005"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(1549), new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(2022) });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "City", "ContactEmail", "ContactName", "ContactPhone", "CreatedAt", "Name", "State", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "88 Kangaroo Court", " Brisbane", " JamesCooper@FFI.com", "James Cooper", "08 9314 7890", new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(2041), "Fresh Food Industries", "VIC", new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(2043) },
                    { new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "23 Sunset Avenue", "Fremantle", "OliviaMiller@GFIFood.com", "Olivia Miller", "03 6234 9087", new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(2046), "GFI Foods", "VIC", new DateTime(2024, 9, 10, 16, 23, 49, 73, DateTimeKind.Local).AddTicks(2048) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"));

            migrationBuilder.DeleteData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("51a801ff-89b7-4663-a308-b0b577018e14"));

            migrationBuilder.DeleteData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"));

            migrationBuilder.DeleteData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"));

            migrationBuilder.DeleteData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"));

            migrationBuilder.DeleteData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"));

            migrationBuilder.DeleteData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"));

            migrationBuilder.DeleteData(
                table: "RestaurantMenus",
                keyColumn: "Id",
                keyValue: new Guid("19924c8f-32e0-4c3d-b425-995ed0ddca5a"));

            migrationBuilder.DeleteData(
                table: "RestaurantMenus",
                keyColumn: "Id",
                keyValue: new Guid("45859bd4-b0bd-4491-8b1b-7c33a940df8a"));

            migrationBuilder.DeleteData(
                table: "RestaurantMenus",
                keyColumn: "Id",
                keyValue: new Guid("6dac4780-fbf3-41f4-8971-b7abdef83a86"));

            migrationBuilder.DeleteData(
                table: "RestaurantMenus",
                keyColumn: "Id",
                keyValue: new Guid("d5d66b38-5140-485b-8575-f83d5fae6a5f"));

            migrationBuilder.DeleteData(
                table: "RestaurantMenus",
                keyColumn: "Id",
                keyValue: new Guid("dd636f75-f510-47eb-bfc8-cf2613defdba"));

            migrationBuilder.DeleteData(
                table: "RestaurantMenus",
                keyColumn: "Id",
                keyValue: new Guid("fc693bcd-807b-4506-a8fd-dc3e31905a81"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: new Guid("114288a7-a300-42c6-8578-5f52df5ce147"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"));

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 8, 17, 51, 37, 436, DateTimeKind.Local).AddTicks(5606), new DateTime(2024, 9, 8, 17, 51, 37, 436, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 8, 17, 51, 37, 436, DateTimeKind.Local).AddTicks(5617), new DateTime(2024, 9, 8, 17, 51, 37, 436, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 8, 17, 51, 37, 436, DateTimeKind.Local).AddTicks(4486), new DateTime(2024, 9, 8, 17, 51, 37, 436, DateTimeKind.Local).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: new Guid("cf762d80-3731-4d9d-af92-b77f99676005"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 14, 30, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
