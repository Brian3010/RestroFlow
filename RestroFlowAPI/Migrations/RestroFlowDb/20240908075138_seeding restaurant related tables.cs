using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestroFlowAPI.Migrations.RestroFlowDb
{
    /// <inheritdoc />
    public partial class seedingrestaurantrelatedtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RestaurantMenus",
                columns: new[] { "Id", "Category", "Description", "DishName", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { new Guid("1d74b052-3b59-465f-add2-d91f96b8961a"), "Fried Chicken (boneless)", "The cornerstone of Gami's authentic Korean taste.", "Regular Chicken", 21m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("4d165d8f-fbcf-4144-a318-374e7f08cb57"), "Fried Chicken (Bone-in)", "The traditional way to enjoy Korean chicken, a hands-on approach.", "Whole-Chicken", 40m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("9ca19c31-2e04-42e7-8cad-6e61bd177eaf"), "Fried Chicken (Boneless)", "Gami's most popular dish is back! Once again served on our signature wooden plate", "The Classic Boneless", 42m, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "City", "ContactEmail", "ContactName", "ContactPhone", "CreatedAt", "Name", "State", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "12 Oceanview Drive", "Bondi Beach", "jane@befood.com", "Jane Smith", "03 9654 3210", new DateTime(2024, 1, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), "B&E Food", "VIC", new DateTime(2024, 1, 1, 14, 30, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "45 Maple Street", "South Yarra", "SarahJohnso@CFS.com", "Sarah Johnso", "07 3345 6721", new DateTime(2024, 1, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), "Complete Food Services", "VIC", new DateTime(2024, 1, 1, 14, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RestaurantItems",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "RestaurantId", "SupplierId", "Unit", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new DateTime(2024, 9, 8, 17, 51, 37, 436, DateTimeKind.Local).AddTicks(5606), null, "Boneless chicken", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "box", new DateTime(2024, 9, 8, 17, 51, 37, 436, DateTimeKind.Local).AddTicks(5613) },
                    { new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new DateTime(2024, 9, 8, 17, 51, 37, 436, DateTimeKind.Local).AddTicks(5617), null, "Chicken powder", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 8, 17, 51, 37, 436, DateTimeKind.Local).AddTicks(5618) },
                    { new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new DateTime(2024, 9, 8, 17, 51, 37, 436, DateTimeKind.Local).AddTicks(4486), null, "Whole chicken", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "Portion", new DateTime(2024, 9, 8, 17, 51, 37, 436, DateTimeKind.Local).AddTicks(5229) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"));

            migrationBuilder.DeleteData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"));

            migrationBuilder.DeleteData(
                table: "RestaurantItems",
                keyColumn: "Id",
                keyValue: new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"));

            migrationBuilder.DeleteData(
                table: "RestaurantMenus",
                keyColumn: "Id",
                keyValue: new Guid("1d74b052-3b59-465f-add2-d91f96b8961a"));

            migrationBuilder.DeleteData(
                table: "RestaurantMenus",
                keyColumn: "Id",
                keyValue: new Guid("4d165d8f-fbcf-4144-a318-374e7f08cb57"));

            migrationBuilder.DeleteData(
                table: "RestaurantMenus",
                keyColumn: "Id",
                keyValue: new Guid("9ca19c31-2e04-42e7-8cad-6e61bd177eaf"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: new Guid("cf762d80-3731-4d9d-af92-b77f99676005"));
        }
    }
}
