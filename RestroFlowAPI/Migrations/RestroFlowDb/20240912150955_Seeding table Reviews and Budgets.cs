using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestroFlowAPI.Migrations.RestroFlowDb
{
    /// <inheritdoc />
    public partial class SeedingtableReviewsandBudgets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReviewSource",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Budgets",
                columns: new[] { "Id", "BudgetAmount", "BudgetCategory", "BudgetEndDate", "BudgetStartDate", "CreatedAt", "Description", "RestaurantId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("42411ba0-467a-4fdd-83cd-d640e1da9721"), 400m, "Others", new DateTime(2024, 9, 13, 1, 9, 55, 238, DateTimeKind.Local).AddTicks(3514), new DateTime(2024, 9, 6, 1, 9, 55, 238, DateTimeKind.Local).AddTicks(3512), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7ea6d1bc-df7e-4d9d-be3e-7d9e4d51b0ec"), 2000m, "Supplies", new DateTime(2024, 9, 13, 1, 9, 55, 238, DateTimeKind.Local).AddTicks(3504), new DateTime(2024, 9, 6, 1, 9, 55, 238, DateTimeKind.Local).AddTicks(3464), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d01bec5c-8129-47c3-bd70-451c74b79451"), 1000m, "Labour", new DateTime(2024, 9, 13, 1, 9, 55, 238, DateTimeKind.Local).AddTicks(3510), new DateTime(2024, 9, 6, 1, 9, 55, 238, DateTimeKind.Local).AddTicks(3509), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Rating", "RestaurantId", "ReviewContent", "ReviewDate", "ReviewSource" },
                values: new object[,]
                {
                    { new Guid("50df28bd-ff5b-42b6-a97f-b0cf0e01ab4e"), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 13, 1, 9, 55, 238, DateTimeKind.Local).AddTicks(3608), "Instagram" },
                    { new Guid("58ef28f9-d581-4cdc-8414-b036fd5caf24"), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 13, 1, 9, 55, 238, DateTimeKind.Local).AddTicks(3626), "Instagram" },
                    { new Guid("702dfb36-c76c-40e9-8924-250b328ac871"), 2f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 13, 1, 9, 55, 238, DateTimeKind.Local).AddTicks(3615), "Instagram" },
                    { new Guid("7c579014-fd46-4bd2-a2ac-a72a75149e55"), 2f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 13, 1, 9, 55, 238, DateTimeKind.Local).AddTicks(3629), "Facebook" },
                    { new Guid("7cfe563f-abea-4cd7-9957-e25946be2e20"), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 13, 1, 9, 55, 238, DateTimeKind.Local).AddTicks(3598), "Others" },
                    { new Guid("a45b386f-4e16-4dd9-97a1-c431da8fc9f4"), 2f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 13, 1, 9, 55, 238, DateTimeKind.Local).AddTicks(3620), "Others" },
                    { new Guid("ca2eba6f-1745-4386-bf2a-cd606bce2370"), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 13, 1, 9, 55, 238, DateTimeKind.Local).AddTicks(3593), "Google" },
                    { new Guid("d5c0c66e-c9eb-4d56-8355-ab63253d677e"), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 13, 1, 9, 55, 238, DateTimeKind.Local).AddTicks(3635), "Others" },
                    { new Guid("e4fa60ad-ff15-4c8a-918a-b935a23c79a3"), 2f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 13, 1, 9, 55, 238, DateTimeKind.Local).AddTicks(3583), "Instagram" },
                    { new Guid("ecb559ff-80e1-46e0-b06d-7ad09a179ff4"), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 13, 1, 9, 55, 238, DateTimeKind.Local).AddTicks(3603), "Facebook" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Budgets",
                keyColumn: "Id",
                keyValue: new Guid("42411ba0-467a-4fdd-83cd-d640e1da9721"));

            migrationBuilder.DeleteData(
                table: "Budgets",
                keyColumn: "Id",
                keyValue: new Guid("7ea6d1bc-df7e-4d9d-be3e-7d9e4d51b0ec"));

            migrationBuilder.DeleteData(
                table: "Budgets",
                keyColumn: "Id",
                keyValue: new Guid("d01bec5c-8129-47c3-bd70-451c74b79451"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("50df28bd-ff5b-42b6-a97f-b0cf0e01ab4e"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("58ef28f9-d581-4cdc-8414-b036fd5caf24"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("702dfb36-c76c-40e9-8924-250b328ac871"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("7c579014-fd46-4bd2-a2ac-a72a75149e55"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("7cfe563f-abea-4cd7-9957-e25946be2e20"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("a45b386f-4e16-4dd9-97a1-c431da8fc9f4"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("ca2eba6f-1745-4386-bf2a-cd606bce2370"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("d5c0c66e-c9eb-4d56-8355-ab63253d677e"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("e4fa60ad-ff15-4c8a-918a-b935a23c79a3"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("ecb559ff-80e1-46e0-b06d-7ad09a179ff4"));

            migrationBuilder.AlterColumn<int>(
                name: "ReviewSource",
                table: "Reviews",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
