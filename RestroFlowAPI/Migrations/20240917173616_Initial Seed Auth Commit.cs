using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestroFlowAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeedAuthCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12a30017-f331-45e6-8944-74f1ee52d686", "12a30017-f331-45e6-8944-74f1ee52d686", "Owner", "OWNER" },
                    { "5f47664-7802-49d9-ba29-f9f30f6d31fa", "5f47664-7802-49d9-ba29-f9f30f6d31fa", "Manager", "MANAGER" },
                    { "7548f645-d440-4f78-a9f7-5c550018507d", "7548f645-d440-4f78-a9f7-5c550018507d", "Admin", "ADMIN" },
                    { "aa60f3e2-a997-4bc9-b16f-1617f950bc88", "aa60f3e2-a997-4bc9-b16f-1617f950bc88", "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "21804e79-b2bb-4a6e-9418-3cab51e579ac", 0, "ab8f6ded-ca66-4a29-9aea-43f345146679", "brian-admin@example.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEBb+4bFsYAHd2tFxrhHrxFlckZRJCYjwdVi9UR9Qg7DJeAnh8DGRkreAig2ePR+jcQ==", null, false, "570a4ade-62b4-41f5-8d45-f7af826a5811", false, "brian-admin@example.com" },
                    { "25a8ee82-6527-4c92-b374-afa6a65cb3b9", 0, "b4382725-d704-4495-8624-6e619780b519", "melissa-staff@example.com", false, false, null, null, null, "AQAAAAIAAYagAAAAELuaoxQsMhrQBfusA2/DvrGN1WkNeAZONIYZz9Aan+yLw3HJ0OvB7oNEmwksBEySBg==", null, false, "7799270d-9da7-419e-a0fe-c7e0e8322813", false, "melissa-staff@example.com" },
                    { "36c8f410-61d4-49fb-beb0-ff35e319614e", 0, "0acfa94d-84f8-4a95-b324-c82d7f45f05b", "charlie-manager@example.com", false, false, null, null, null, "AQAAAAIAAYagAAAAED3qaHJTYjUqCFpIJa3AXDHZaGDGmUOvySPdM8leOGbhMxFASoXOnLhH8BGiUzc/6A==", null, false, "38609e82-8ac7-445d-bf03-caa6b781db2f", false, "charlie-manager@example.com" },
                    { "55bc7fd2-de9a-4a8b-9bb8-5d384b8e8f23", 0, "5351301e-cd39-4f45-b5e7-23442f294e35", "thomas-staff@example.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEMiI6X7xT8zfm7YjZ2RLbPIm8g0h2b410y6qfVu8WU44hb5Mgp1Hvyb6Y3pu0s/M4w==", null, false, "09d4e164-1316-4214-98b0-a274a4ed1869", false, "thomas-staff@example.com" },
                    { "9125374f-e121-40f2-b42f-089529dd5fbd", 0, "9e0c898d-2b9b-47a8-b261-856debb44036", "bob-manager@example.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEFHN/ptfcJ985ZE9lODiOJYekzTMPWV+QFHj1LAxta00uItKQA6T74y9SOR9x9a4AA==", null, false, "fcba049c-a895-4ffb-a631-6497243e540d", false, "bob-manager@example.com" },
                    { "f2ba15e2-f1d3-43d1-bb84-6767253ebbe2", 0, "946413b1-eaec-4d9a-b4b0-450f38d6f97e", "alice-owner@example.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEL8xao9lIVwPhXMjBFfhasukphsYceBlXRzyxT0lABcfD/LNcXvXhixDYZ+78VmYDA==", null, false, "896cc988-16a2-4e6c-a8b5-9ac766a45d4f", false, "alice-owner@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7548f645-d440-4f78-a9f7-5c550018507d", "21804e79-b2bb-4a6e-9418-3cab51e579ac" },
                    { "aa60f3e2-a997-4bc9-b16f-1617f950bc88", "25a8ee82-6527-4c92-b374-afa6a65cb3b9" },
                    { "5f47664-7802-49d9-ba29-f9f30f6d31fa", "36c8f410-61d4-49fb-beb0-ff35e319614e" },
                    { "aa60f3e2-a997-4bc9-b16f-1617f950bc88", "55bc7fd2-de9a-4a8b-9bb8-5d384b8e8f23" },
                    { "5f47664-7802-49d9-ba29-f9f30f6d31fa", "9125374f-e121-40f2-b42f-089529dd5fbd" },
                    { "12a30017-f331-45e6-8944-74f1ee52d686", "f2ba15e2-f1d3-43d1-bb84-6767253ebbe2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
