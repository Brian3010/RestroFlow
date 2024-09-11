using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestroFlowAPI.Migrations.RestroFlowDb
{
    /// <inheritdoc />
    public partial class Seedingtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(3609), new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(3603), new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(3280), new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(3411) });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Address", "City", "CreatedAt", "Name", "Suburb", "UpdatedAt" },
                values: new object[] { new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), "840 Glenferrie Rd, Hawthorn VIC 3122", "Mebourne", new DateTime(2024, 1, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), "Gami Chicken and Beer", "Hawthorn", new DateTime(2024, 1, 1, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "City", "ContactEmail", "ContactName", "ContactPhone", "CreatedAt", "Name", "State", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "12 Oceanview Drive", "Bondi Beach", "jane@befood.com", "Jane Smith", "03 9654 3210", new DateTime(2024, 1, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), "B&E Food", "VIC", new DateTime(2024, 1, 1, 14, 30, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "88 Kangaroo Court", " Brisbane", " JamesCooper@FFI.com", "James Cooper", "08 9314 7890", new DateTime(2024, 9, 12, 0, 49, 24, 442, DateTimeKind.Local).AddTicks(9829), "Fresh Food Industries", "VIC", new DateTime(2024, 9, 12, 0, 49, 24, 442, DateTimeKind.Local).AddTicks(9831) },
                    { new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "23 Sunset Avenue", "Fremantle", "OliviaMiller@GFIFood.com", "Olivia Miller", "03 6234 9087", new DateTime(2024, 9, 12, 0, 49, 24, 442, DateTimeKind.Local).AddTicks(9844), "GFI Foods", "VIC", new DateTime(2024, 9, 12, 0, 49, 24, 442, DateTimeKind.Local).AddTicks(9845) },
                    { new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "45 Maple Street", "South Yarra", "SarahJohnso@CFS.com", "Sarah Johnso", "07 3345 6721", new DateTime(2024, 9, 12, 0, 49, 24, 442, DateTimeKind.Local).AddTicks(9273), "Complete Food Services", "VIC", new DateTime(2024, 9, 12, 0, 49, 24, 442, DateTimeKind.Local).AddTicks(9821) }
                });

            migrationBuilder.InsertData(
                table: "RestaurantItems",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "RestaurantId", "SupplierId", "Unit", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(2780), null, "Chicken wings", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(2782) },
                    { new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(2760), null, "Boneless chicken", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "box", new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(2764) },
                    { new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(2809), null, "Spicy sauce", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(2811) },
                    { new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(2816), null, "Sweet Chiilies", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(2817) },
                    { new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(2794), null, "Marinated beef", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion", new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(2795) },
                    { new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(2821), null, "Wedges", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(2822) },
                    { new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(2799), null, "Chicken powder", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(2801) },
                    { new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(2302), null, "Whole chicken", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "Portion", new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(2436) },
                    { new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(2786), null, "Chicken Steak", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(2787) },
                    { new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(2804), null, "Soy garlic", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 12, 0, 49, 24, 443, DateTimeKind.Local).AddTicks(2806) }
                });

            migrationBuilder.InsertData(
                table: "RestaurantMenus",
                columns: new[] { "Id", "Category", "Description", "DishName", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { new Guid("07a67762-a063-46db-94d1-080237b187a5"), "Korean Classics", "", "Kimchi Pancake", 16m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("19924c8f-32e0-4c3d-b425-995ed0ddca5a"), "Korean Classics", "Tender slices of marinated beef and ve ies stir-fried with sweet potato noodles in a sweet soy sauce, served with rice and a fresh green salad with Tangerine dressing.", "Beef Bulgogi", 18.5m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("1d74b052-3b59-465f-add2-d91f96b8961a"), "Fried Chicken (boneless)", "The cornerstone of Gami's authentic Korean taste.", "Regular Chicken", 21m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("29585767-ced3-46a6-8f1f-06455c4b1172"), "Korean Classics", "", "Kimchi Fried Rice", 13.5m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("45859bd4-b0bd-4491-8b1b-7c33a940df8a"), "Fried Chicken (boneless)", "A mix of chicken wingettes and drumettes.", "10 Wings", 17m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("4d165d8f-fbcf-4144-a318-374e7f08cb57"), "Fried Chicken (Bone-in)", "The traditional way to enjoy Korean chicken, a hands-on approach.", "Whole-Chicken", 40m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("6dac4780-fbf3-41f4-8971-b7abdef83a86"), "Sides", "Locally grown cut potato strips coated in Gami signature batter.", "Gami Chips", 6.9m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("6e4aaccc-3c0d-4d91-a8e0-10e1a70a24f2"), "Sides", "", "Chicken Burger", 15m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("75734df5-e59e-4d9e-a224-ed8e4ae67fdd"), "Sides", "", "Chicken Skewers ", 10m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("9ca19c31-2e04-42e7-8cad-6e61bd177eaf"), "Fried Chicken (Boneless)", "Gami's most popular dish is back! Once again served on our signature wooden plate", "The Classic Boneless", 42m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("bab92f8b-1fd6-4fbb-9c66-777c49280d54"), "Korean Classics", "", "Japchae", 15.5m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("d02988c8-bd91-400d-8593-403c285c6dfb"), "Sides", "", "Chicken Skewer plate", 28m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("d5d66b38-5140-485b-8575-f83d5fae6a5f"), "Korean Classics", "A healthy and delicious Korean rice dish showcasing flavourful vegetables, your preferred protein and a choice of sauce. Topped with a fried egg.", "Korean Classics", 16m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("dd636f75-f510-47eb-bfc8-cf2613defdba"), "Korean Classics", "TA beloved Korean favourite, featuring stir-fried rice cakes, fish cakes, assorted vegetables, and noodles, all coated in a rich and spicy Korean chilli sauce.", "Tteok Bokki", 14.5m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("f6c1d21b-b9dd-452f-8e14-364f530bf7b8"), "Sides", "", "Potato Heaven", 16.5m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("fc693bcd-807b-4506-a8fd-dc3e31905a81"), "Sides", "5 deep-fried premium handmade dumplings, filled with chunky prawn meat wrapped in thin crispy skin.", "Prawn Mandu", 14.5m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") }
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
                keyValue: new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"));

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
                keyValue: new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"));

            migrationBuilder.DeleteData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"));

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
                keyValue: new Guid("07a67762-a063-46db-94d1-080237b187a5"));

            migrationBuilder.DeleteData(
                table: "RestaurantMenus",
                keyColumn: "Id",
                keyValue: new Guid("19924c8f-32e0-4c3d-b425-995ed0ddca5a"));

            migrationBuilder.DeleteData(
                table: "RestaurantMenus",
                keyColumn: "Id",
                keyValue: new Guid("1d74b052-3b59-465f-add2-d91f96b8961a"));

            migrationBuilder.DeleteData(
                table: "RestaurantMenus",
                keyColumn: "Id",
                keyValue: new Guid("29585767-ced3-46a6-8f1f-06455c4b1172"));

            migrationBuilder.DeleteData(
                table: "RestaurantMenus",
                keyColumn: "Id",
                keyValue: new Guid("45859bd4-b0bd-4491-8b1b-7c33a940df8a"));

            migrationBuilder.DeleteData(
                table: "RestaurantMenus",
                keyColumn: "Id",
                keyValue: new Guid("4d165d8f-fbcf-4144-a318-374e7f08cb57"));

            migrationBuilder.DeleteData(
                table: "RestaurantMenus",
                keyColumn: "Id",
                keyValue: new Guid("6dac4780-fbf3-41f4-8971-b7abdef83a86"));

            migrationBuilder.DeleteData(
                table: "RestaurantMenus",
                keyColumn: "Id",
                keyValue: new Guid("6e4aaccc-3c0d-4d91-a8e0-10e1a70a24f2"));

            migrationBuilder.DeleteData(
                table: "RestaurantMenus",
                keyColumn: "Id",
                keyValue: new Guid("75734df5-e59e-4d9e-a224-ed8e4ae67fdd"));

            migrationBuilder.DeleteData(
                table: "RestaurantMenus",
                keyColumn: "Id",
                keyValue: new Guid("9ca19c31-2e04-42e7-8cad-6e61bd177eaf"));

            migrationBuilder.DeleteData(
                table: "RestaurantMenus",
                keyColumn: "Id",
                keyValue: new Guid("bab92f8b-1fd6-4fbb-9c66-777c49280d54"));

            migrationBuilder.DeleteData(
                table: "RestaurantMenus",
                keyColumn: "Id",
                keyValue: new Guid("d02988c8-bd91-400d-8593-403c285c6dfb"));

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
                keyValue: new Guid("f6c1d21b-b9dd-452f-8e14-364f530bf7b8"));

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

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: new Guid("cf762d80-3731-4d9d-af92-b77f99676005"));

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
        }
    }
}
