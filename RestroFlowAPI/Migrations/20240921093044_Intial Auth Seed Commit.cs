using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestroFlowAPI.Migrations
{
    /// <inheritdoc />
    public partial class IntialAuthSeedCommit : Migration
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
                    { "21804e79-b2bb-4a6e-9418-3cab51e579ac", 0, "56394699-76b1-471f-ac50-3be45a875ef2", "brian-admin@example.com", false, false, null, "BRIAN-ADMIN@EXAMPLE.COM", "BRIAN-ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOtwM1Dm/6g5F8nwG46auYP8MY5Y4a0YE8LH5GA+0iKPtYIYcJyjX1TaqvN4bmyLNA==", null, false, "8e9c8212-9f02-406c-81a3-b96afaf11621", false, "brian-admin@example.com" },
                    { "25a8ee82-6527-4c92-b374-afa6a65cb3b9", 0, "4659f876-b1cd-4c4f-891c-f3affc6bb37f", "melissa-staff@example.com", false, false, null, "MELISSA-STAFF@EXAMPLE.COM", "MELISSA-STAFF@EXAMPLE.COM", "AQAAAAIAAYagAAAAECbeNcIn/ry3dCm0mNqR7TxsFERLbiup4IYN0RilGIYtjYFUmnoAv8nvJnMJMAS3xg==", null, false, "adf29cc5-3e1b-4a8b-9c3a-fc5a3f96d9c3", false, "melissa-staff@example.com" },
                    { "36c8f410-61d4-49fb-beb0-ff35e319614e", 0, "059bed4a-661e-4435-9a09-8d1d33ed4d9a", "charlie-manager@example.com", false, false, null, "CHARLIE-MANAGER@EXAMPLE.COM", "CHARLIE-MANAGER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOScjU/1q7Xjq1ySdJ9IJ0VRW59GpgxLxUzMe5K664eYZtmHaJoC9HjW+L0YCydbcQ==", null, false, "f4761c29-5625-4d1f-9e57-2fae3cf09b4c", false, "charlie-manager@example.com" },
                    { "55bc7fd2-de9a-4a8b-9bb8-5d384b8e8f23", 0, "53c97e20-cc61-4553-bef6-83ba76c56ebc", "thomas-staff@example.com", false, false, null, "THOMAS-STAFF@EXAMPLE.COM", "THOMAS-STAFF@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMLHdu3nJnOmEpvBjuH6dLN2ErTwJVZaUrIveAoCKl2ueFq1DcH9tuFqSzaDiFkiwg==", null, false, "f0a755db-fd24-472c-b122-fdff97ae44a8", false, "thomas-staff@example.com" },
                    { "9125374f-e121-40f2-b42f-089529dd5fbd", 0, "44cfcb50-c5e0-44fc-9543-edb948e8c3ba", "bob-manager@example.com", false, false, null, "BOB-MANAGER@EXAMPLE.COM", "BOB-MANAGER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEL/oTknuh1ylPpV2SPg6NxjAmJ+Tbgt84XKOlPTnk6LjcZbQRIbF6UsQCUmUCse3cg==", null, false, "3b25ad51-b0f8-4194-bcd9-c5e03097e3ed", false, "bob-manager@example.com" },
                    { "f2ba15e2-f1d3-43d1-bb84-6767253ebbe2", 0, "7eba8b5f-75ec-4f00-9e23-ccd561468108", "alice-owner@example.com", false, false, null, "ALICE-OWNER@EXAMPLE.COM", "ALICE-OWNER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDsKyCUgYH2vrw5rpO6IJfoCOamTgfEaqstEin4K9GVwzCTSycHQAySnG7o+c23gIw==", null, false, "2a0148c7-65a4-40bf-b016-973af7c30a14", false, "alice-owner@example.com" }
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
