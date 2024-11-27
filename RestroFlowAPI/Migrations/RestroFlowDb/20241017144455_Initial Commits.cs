using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestroFlowAPI.Migrations.RestroFlowDb
{
    /// <inheritdoc />
    public partial class InitialCommits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlertRecipients",
                columns: table => new
                {
                    AlertRecipientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecipientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlertRecipients", x => x.AlertRecipientId);
                });

            migrationBuilder.CreateTable(
                name: "ItemLocations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Suburb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BudgetExpenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetExpenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BudgetExpenses_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventoryReports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RestaurantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryReports_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReviewSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: true),
                    RestaurantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RestaurantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemLocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantItems_ItemLocations_ItemLocationId",
                        column: x => x.ItemLocationId,
                        principalTable: "ItemLocations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RestaurantItems_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RestaurantItems_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SupplierItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupplierItems_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Budgets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BudgetAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BudgetStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BudgetEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BudgetCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestaurantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budgets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Budgets_BudgetExpenses_BudgetCategoryId",
                        column: x => x.BudgetCategoryId,
                        principalTable: "BudgetExpenses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Budgets_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpenseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpenseTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestaurantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_BudgetExpenses_ExpenseTypeId",
                        column: x => x.ExpenseTypeId,
                        principalTable: "BudgetExpenses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Expenses_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InventoryAlerts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Threshold = table.Column<float>(type: "real", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RestaurantItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryAlerts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryAlerts_RestaurantItems_RestaurantItemId",
                        column: x => x.RestaurantItemId,
                        principalTable: "RestaurantItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantInventories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<float>(type: "real", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUdpated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RestaurantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestaurantItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantInventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantInventories_RestaurantItems_RestaurantItemId",
                        column: x => x.RestaurantItemId,
                        principalTable: "RestaurantItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RestaurantInventories_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RestaurantInventories_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StockOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestaurantItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestaurantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockOrders_RestaurantItems_RestaurantItemId",
                        column: x => x.RestaurantItemId,
                        principalTable: "RestaurantItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StockOrders_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StockOrders_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SupplierInventories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<float>(type: "real", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierInventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupplierInventories_SupplierItems_SupplierItemId",
                        column: x => x.SupplierItemId,
                        principalTable: "SupplierItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SupplierInventories_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AlertRecipients",
                columns: new[] { "AlertRecipientId", "RecipientId" },
                values: new object[,]
                {
                    { new Guid("053291ac-5cda-472d-a514-f7aebbea1c07"), new Guid("36c8f410-61d4-49fb-beb0-ff35e319614e") },
                    { new Guid("c51825bd-87d9-40ec-b2e2-71fc5ec758f1"), new Guid("21804e79-b2bb-4a6e-9418-3cab51e579ac") },
                    { new Guid("e7e76aff-7eca-4726-8802-849cc89a5cb8"), new Guid("f2ba15e2-f1d3-43d1-bb84-6767253ebbe2") },
                    { new Guid("eb72967b-df37-4bc2-8d71-610ba18d6261"), new Guid("9125374f-e121-40f2-b42f-089529dd5fbd") }
                });

            migrationBuilder.InsertData(
                table: "ItemLocations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("45a8b26b-d146-42be-b306-6159a02bca1c"), "Back of House Stock Lists" },
                    { new Guid("a1bc96a5-8353-4afc-a0f1-cf1f2ccafe51"), "Front of House Stock Lists" }
                });

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
                    { new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "88 Kangaroo Court", " Brisbane", " JamesCooper@FFI.com", "James Cooper", "08 9314 7890", new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(697), "Fresh Food Industries", "VIC", new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(698) },
                    { new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "23 Sunset Avenue", "Fremantle", "OliviaMiller@GFIFood.com", "Olivia Miller", "03 6234 9087", new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(702), "GFI Foods", "VIC", new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(703) },
                    { new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "45 Maple Street", "South Yarra", "SarahJohnso@CFS.com", "Sarah Johnso", "07 3345 6721", new DateTime(2024, 10, 18, 1, 44, 54, 948, DateTimeKind.Local).AddTicks(9997), "Complete Food Services", "VIC", new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(688) }
                });

            migrationBuilder.InsertData(
                table: "BudgetExpenses",
                columns: new[] { "Id", "Name", "RestaurantId" },
                values: new object[,]
                {
                    { new Guid("a57b3ede-7810-44d9-9f73-04dfa330a971"), "Supplies", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("d9b33212-dc51-4174-8e9d-299858f0ea88"), "Labor", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") }
                });

            migrationBuilder.InsertData(
                table: "RestaurantItems",
                columns: new[] { "Id", "CreatedAt", "Description", "ItemLocationId", "Name", "RestaurantId", "SupplierId", "Unit", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(3918), null, new Guid("45a8b26b-d146-42be-b306-6159a02bca1c"), "Chicken wings", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(3919) },
                    { new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(3907), null, new Guid("45a8b26b-d146-42be-b306-6159a02bca1c"), "Boneless chicken", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "box", new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(3913) },
                    { new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(3945), null, new Guid("a1bc96a5-8353-4afc-a0f1-cf1f2ccafe51"), "Spicy sauce", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(3946) },
                    { new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(3958), null, new Guid("a1bc96a5-8353-4afc-a0f1-cf1f2ccafe51"), "Sweet Chiilies", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(3959) },
                    { new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(3930), null, new Guid("45a8b26b-d146-42be-b306-6159a02bca1c"), "Marinated beef", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion", new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(3931) },
                    { new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(3963), null, new Guid("a1bc96a5-8353-4afc-a0f1-cf1f2ccafe51"), "Wedges", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(3964) },
                    { new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(3935), null, new Guid("a1bc96a5-8353-4afc-a0f1-cf1f2ccafe51"), "Chicken powder", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(3937) },
                    { new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(2865), null, new Guid("45a8b26b-d146-42be-b306-6159a02bca1c"), "Whole chicken", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "Portion", new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(2994) },
                    { new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(3923), null, new Guid("45a8b26b-d146-42be-b306-6159a02bca1c"), "Chicken Steak", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(3924) },
                    { new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(3940), null, new Guid("a1bc96a5-8353-4afc-a0f1-cf1f2ccafe51"), "Soy garlic", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 18, 1, 44, 54, 949, DateTimeKind.Local).AddTicks(3941) }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Rating", "RestaurantId", "ReviewContent", "ReviewDate", "ReviewSource" },
                values: new object[,]
                {
                    { new Guid("1ed62e5f-382f-4f29-8670-d134567a6bb2"), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8532), "Facebook" },
                    { new Guid("38097375-90d3-4222-9147-7973fa3c0fa0"), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8496), "Instagram" },
                    { new Guid("4674d39d-f8bf-4ce3-bcb7-db2ed134d91f"), 2f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8514), "Others" },
                    { new Guid("7c0ccdbe-b0ec-4493-972f-040d7ab14e92"), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8510), "Google" },
                    { new Guid("8f4c6a6e-b1bc-4b5c-9408-5ccb52c56981"), 2f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8505), "Others" },
                    { new Guid("904b3b92-1b62-4d5b-ae1c-04ee37ecef5e"), 2f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8519), "Instagram" },
                    { new Guid("9171b93d-76ca-4ce3-8c52-ebc56ad8ffb6"), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8527), "Facebook" },
                    { new Guid("984895b5-24a7-4055-98ad-7b65f41925ae"), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8487), "Facebook" },
                    { new Guid("b136c928-9147-4fcb-93ad-8c16cc73c742"), 2f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8500), "Google" },
                    { new Guid("d673007b-5a9d-43c7-b63a-abb7eff357cc"), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8522), "Google" }
                });

            migrationBuilder.InsertData(
                table: "SupplierItems",
                columns: new[] { "Id", "CreateAt", "Description", "Name", "Price", "SupplierId", "Unit", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0500c909-85db-411c-970e-56da5880b40a"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9307), null, "Japchae mandu", 20.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "pack", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9308) },
                    { new Guid("0a4b117b-1d0b-40bd-9c4a-c67cf8efabe2"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9087), null, "Frying mix", 30.9m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9088) },
                    { new Guid("0a5f2f50-7f4f-417d-8cab-a8033037de55"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9235), null, "Red spicy mayo", 10m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9236) },
                    { new Guid("124bb792-1e66-4446-a6d5-6454a8ae59ef"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9096), null, "Sweet chillies", 25m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9098) },
                    { new Guid("15ddc62b-3ecc-4344-ad67-d01367420753"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9231), null, "Slider bun", 13.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9232) },
                    { new Guid("1b8d027e-4a55-4f2a-8604-e94e27b69bcd"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9226), null, "Burger bun", 25m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9227) },
                    { new Guid("1c0849ec-d7d0-4b36-a39d-727e83df8541"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9006), null, "Whole chicken", 22m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "pack", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9008) },
                    { new Guid("1ef0b562-73c4-453e-a655-3bc9089493ba"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9150), null, "Seasame oil", 17.5m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "can", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9151) },
                    { new Guid("23169bfa-ee7f-451f-902b-c9c7d76d82ff"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9201), null, "Potato noodle", 25m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "box", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9202) },
                    { new Guid("24652c91-d843-41a9-8a0d-e01765078320"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9102), null, "Corn kernel", 25m, new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9103) },
                    { new Guid("24e2b8f1-1cdb-4b7b-8f60-c3932ec38e4c"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9023), null, "Coleslaw", 30.9m, new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9024) },
                    { new Guid("27a689d7-86eb-46bd-abef-661004f17cac"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9219), null, "Soy sauce", 34m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "jerrycan", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9220) },
                    { new Guid("2a2378bf-3e11-460e-8d5e-3a4aedb27aa3"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9214), null, "Sour cream", 10m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "tub", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9215) },
                    { new Guid("2b5e4f31-7ca9-42d5-9206-8d2314cc61e7"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9017), null, "Chicken powder", 20.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9018) },
                    { new Guid("2b76b61d-4ddf-4d93-8d2f-2801526392fb"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9154), null, "Boiled gochujang", 25m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9155) },
                    { new Guid("4820911b-7e10-4e74-bd3d-1b15941eae9f"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9115), null, "Wedges", 30.2m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9116) },
                    { new Guid("4f1aeecf-3def-4ee2-8676-10e3537cb39d"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9179), null, "Carrot rings", 30.2m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "pack", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9180) },
                    { new Guid("51fdeb2b-fb64-458a-8599-45ff31f225df"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9167), null, "Boxing wings", 50m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9168) },
                    { new Guid("5e1e95e9-e936-4a79-9c2c-1495834c8884"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9222), null, "Mozzarella cheese", 22m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9223) },
                    { new Guid("600045b8-e356-48e8-b635-2e93d50aa0bb"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9039), null, "Soy garlic", 25m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9040) },
                    { new Guid("60d05a1d-fb0a-4a5e-8ddd-6e61f0f0cde9"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9210), null, "Fish cake", 21m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9211) },
                    { new Guid("682e87e5-186d-43b1-8813-27b3285b67a2"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9198), null, "Milk", 21m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "carton", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9199) },
                    { new Guid("6bfc57be-3d25-46cf-a52f-1be1d75e7734"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9163), null, "Beef dashida", 21m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9164) },
                    { new Guid("70421cdf-9c2f-4b1d-9b21-b6652005ddca"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9034), null, "Boneless Chicken", 22m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "box", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9036) },
                    { new Guid("73ace0bd-0b50-4be1-a6d3-e4c8ebb98f86"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9299), null, "Prawn mandu", 30.9m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "pack", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9300) },
                    { new Guid("7632b25f-d2bd-4b85-a7f8-8f2b40c668cd"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9316), null, "K-donut", 10m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "pack", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9317) },
                    { new Guid("79e60cb4-c664-4606-ad7f-abe54e620950"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9158), null, "Corn ribs", 30.2m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "pack", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9159) },
                    { new Guid("7a732ee7-b39e-43c8-a05a-5c4a2ff63246"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9172), null, "Mustard", 20.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9173) },
                    { new Guid("7db386cb-7af8-4bf7-a997-bb90a0707cfb"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9110), null, "Marinated beef", 20.5m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9111) },
                    { new Guid("7fd51a7d-15c8-404c-bd9d-7f1790485117"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9138), null, "Corn syrup", 19.9m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "gallon", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9139) },
                    { new Guid("80e03b7f-82f3-4784-ba27-d2bb7fb20fde"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9141), null, "Skewers", 25m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9142) },
                    { new Guid("823d740c-54ab-48f1-8a49-08ace16231d0"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9049), null, "Rice cake", 22m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9050) },
                    { new Guid("862c3823-01f5-447f-b7b5-6028a00a885e"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9294), null, "Tomato Relish", 50m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bottle", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9295) },
                    { new Guid("87b66401-bbed-4b82-9947-3a325d7cb53f"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9029), null, "Instant noodle", 22m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "pack", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9030) },
                    { new Guid("8d0650b2-8f11-4a1e-82a4-54d95dca9e3b"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9106), null, "Pancake mix", 13.5m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9107) },
                    { new Guid("9363413b-db4a-49b9-b439-32af79fe593a"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9053), null, "Chicken wings", 30.9m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9054) },
                    { new Guid("992cd642-c850-4dbd-be63-2a0063f2a712"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9258), null, "Cheese sauce", 21m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9259) },
                    { new Guid("a3c782d4-a8c5-4216-8862-22ded5719e90"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9206), null, "Mayonnaise", 20.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bucket", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9207) },
                    { new Guid("a647890a-ea78-41b4-8701-a6606d388008"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9185), null, "Ketchup", 25m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "gallon", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9186) },
                    { new Guid("a647d226-7baa-4e3e-be69-d0b86a553f5d"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9245), null, "Tteokbokki sauce", 34m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9246) },
                    { new Guid("aec6e57d-4c35-4955-bdfd-9c65bd16e7f1"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9145), null, "Shoestring chips", 20.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9146) },
                    { new Guid("b0eb17a8-1fce-44ae-80e2-0683208cfbe0"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9128), null, "Drumstick", 25m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9129) },
                    { new Guid("c30fc9e0-694c-482d-827d-ddd620108b0e"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9062), null, "Mix salad", 21m, new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "box", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9063) },
                    { new Guid("c3e183ec-88ac-45be-aef4-a95e4a6bf136"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9290), null, "Whole gain mustard", 19.9m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "tub", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9291) },
                    { new Guid("c49b811f-b0ca-450e-a64d-c46bcd6a79bc"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9189), null, "Thai sweet chilli", 30.2m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "gallon", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9190) },
                    { new Guid("c78e0f00-06d5-4c9e-86ee-327c88c7240b"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9254), null, "Salted butter", 19.9m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "pack", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9255) },
                    { new Guid("c86f2d5b-6624-4d72-83f5-32a02bc72ebb"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9092), null, "Chicken steak", 20.5m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9093) },
                    { new Guid("cc208409-8195-45df-b215-c7cb4d9c37ef"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9176), null, "Kimchi", 21m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "container", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9177) },
                    { new Guid("cc752164-49c4-4a18-b007-0af7496ab0da"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9123), null, "Dumpling", 50m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9124) },
                    { new Guid("cd30cd96-908f-4391-bade-69da9b855aba"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9132), null, "Chips", 50m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9133) },
                    { new Guid("d3c1565a-7e2d-488f-889a-3fee4166a166"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9058), null, "Spicy sauce", 13.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9059) },
                    { new Guid("d51c4d09-e737-4381-a72b-524742a3ac1a"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9312), null, "Hotteok", 11m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "pack", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9313) },
                    { new Guid("dd55fed7-df1d-4cae-a722-b99106ef8936"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9249), null, "Crushed garlic", 30.2m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bucket", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9250) },
                    { new Guid("e8fc53ec-b408-454f-86a4-c07e1ed8e073"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9119), null, "Dried garlic", 30.9m, new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "container", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9120) },
                    { new Guid("e93346fb-093c-4e86-966f-d5f642dd645a"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9303), null, "Prawn burger", 50m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "pack", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9304) },
                    { new Guid("ebf4bbd9-f9ef-4488-806b-0d78a6a271ce"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9192), null, "Eggs", 30.9m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "dozen", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9193) },
                    { new Guid("ef2e2015-042d-481a-9b05-47dd9610c323"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9284), null, "Potato flake", 30.2m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9285) },
                    { new Guid("f623a5dc-5385-43fc-bf8c-0a8c7bef48c5"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9241), null, "Gochujang sauce", 20.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9242) },
                    { new Guid("fb9a9e8d-bc5e-46fd-9f25-ed20b9c6760d"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9045), null, "White radish", 10m, new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "container", new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(9046) }
                });

            migrationBuilder.InsertData(
                table: "Budgets",
                columns: new[] { "Id", "BudgetAmount", "BudgetCategoryId", "BudgetEndDate", "BudgetStartDate", "CreatedAt", "Description", "RestaurantId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("3898fdeb-eacf-473e-afe5-04c21ce79779"), 2000m, new Guid("a57b3ede-7810-44d9-9f73-04dfa330a971"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8446), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8444), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("513ad5bf-f945-46eb-9d01-87ca1fb2a4e1"), 1000m, new Guid("d9b33212-dc51-4174-8e9d-299858f0ea88"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8457), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8456), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Amount", "ExpenseDate", "ExpenseTypeId", "RestaurantId" },
                values: new object[,]
                {
                    { new Guid("0d4cf378-23c9-4434-b125-5114a4a5c634"), 80m, new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7771), new Guid("a57b3ede-7810-44d9-9f73-04dfa330a971"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("13e655b8-0605-40de-ae5b-db09d265be0f"), 250m, new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7768), new Guid("d9b33212-dc51-4174-8e9d-299858f0ea88"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("16ec9c74-f72c-41e8-98a3-9cd9aea05cc4"), 80m, new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7788), new Guid("a57b3ede-7810-44d9-9f73-04dfa330a971"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("1a979fce-8e3f-4d45-ab35-e3a595bbf090"), 120m, new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7763), new Guid("a57b3ede-7810-44d9-9f73-04dfa330a971"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("1f0255d9-9b36-4320-a173-cc144e41f89f"), 250m, new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7730), new Guid("a57b3ede-7810-44d9-9f73-04dfa330a971"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("29a135f0-1a51-4a34-9c57-43b0dc025d9c"), 100m, new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7780), new Guid("a57b3ede-7810-44d9-9f73-04dfa330a971"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("7b72900e-97fd-4365-83fe-a55705ebc316"), 250m, new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7643), new Guid("a57b3ede-7810-44d9-9f73-04dfa330a971"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("937a013f-492a-402a-a446-8dc3cffcbf9a"), 120m, new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7701), new Guid("d9b33212-dc51-4174-8e9d-299858f0ea88"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("ad1d4228-70da-48cb-820a-17fe300505d9"), 120m, new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7793), new Guid("a57b3ede-7810-44d9-9f73-04dfa330a971"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("b9b5e463-46dd-4ed0-8b33-bb1f21f8ca1d"), 80m, new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7722), new Guid("a57b3ede-7810-44d9-9f73-04dfa330a971"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("babc744d-5f21-4130-b631-53079e776e52"), 100m, new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7735), new Guid("d9b33212-dc51-4174-8e9d-299858f0ea88"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("c0e776ba-b964-436c-9229-d886981eb02a"), 80m, new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7776), new Guid("d9b33212-dc51-4174-8e9d-299858f0ea88"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("d6c15686-8108-467b-9b2a-ac842858ec5c"), 80m, new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7798), new Guid("d9b33212-dc51-4174-8e9d-299858f0ea88"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("e42e31cc-6a66-4ca8-be13-fae8eca748ab"), 100m, new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7791), new Guid("d9b33212-dc51-4174-8e9d-299858f0ea88"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("f91ce906-eed3-40c1-b8a6-fabb4a9d3caf"), 250m, new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7783), new Guid("d9b33212-dc51-4174-8e9d-299858f0ea88"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("fef152f2-6fd4-4cef-a75b-832545c30430"), 120m, new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7725), new Guid("d9b33212-dc51-4174-8e9d-299858f0ea88"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") }
                });

            migrationBuilder.InsertData(
                table: "InventoryAlerts",
                columns: new[] { "Id", "CreatedAt", "RestaurantItemId", "Threshold", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("143a3c18-9e73-4f13-ab6f-fc915cc44660"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8384), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), 20f, new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8385) },
                    { new Guid("1a39d818-da81-49c8-a88b-3b88b0467567"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8315), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), 9f, new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8316) },
                    { new Guid("2d279916-e02f-4df1-88f3-65973fc921ed"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8375), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), 20f, new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8376) },
                    { new Guid("6699a427-990b-4801-9c22-76a836ed888d"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8320), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), 25f, new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8322) },
                    { new Guid("6e14eb8a-bdb8-47f0-9abc-afbdceccb0dd"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8388), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), 3f, new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8389) },
                    { new Guid("869309d7-6cff-4195-bb0e-f17b4c2ada8c"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8330), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), 20f, new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8331) },
                    { new Guid("9677cf2a-31f2-4215-84cb-b80939d850d0"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8379), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), 25f, new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8380) },
                    { new Guid("b60c1509-3cdb-4ffc-b88e-0cab2b3cf067"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8393), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), 10f, new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8394) },
                    { new Guid("c8de1ae6-d15e-41a0-bd41-57279140bb90"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8324), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), 10f, new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8326) },
                    { new Guid("e86e8e05-aec8-4b67-9e87-6d38c857e06b"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8309), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), 8f, new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8310) }
                });

            migrationBuilder.InsertData(
                table: "RestaurantInventories",
                columns: new[] { "Id", "LastUdpated", "Quantity", "RestaurantId", "RestaurantItemId", "SupplierId", "Unit" },
                values: new object[,]
                {
                    { new Guid("019c81ce-7b35-4a6b-b171-3f67724bf9c5"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7945), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "container" },
                    { new Guid("048b328f-9880-4f7b-97e9-62daaebeb3a0"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8100), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("060ba7f2-7732-42d6-9ff3-935cc3b65e07"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8044), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("06ca53ce-5a34-467f-9f94-476051df6dea"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8222), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "container" },
                    { new Guid("07491100-28a3-4da8-92ca-2b4dc7f19316"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8034), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("09c5bde4-fa26-4293-9b08-f85726a26e9c"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7908), 22f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "box" },
                    { new Guid("0a0d83c8-cb57-48cf-8528-1c40c3eae894"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8229), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("0adaec08-16fa-4eb5-8f6b-9b5699dbcdf3"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7932), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("0b471140-a18e-453c-9121-80a3501fa80d"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8146), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "Portion" },
                    { new Guid("0ea1bec2-a7b8-48bc-af5c-639ca7b1802e"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7940), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "Portion" },
                    { new Guid("12b5fe30-28a6-4e29-9ba2-ccfb97175291"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8061), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "portion" },
                    { new Guid("19fc0535-23f3-4405-a0e8-03a40e4b5387"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8129), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("1a600a51-b679-463f-ba1a-4697e798960f"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8207), 9f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("2366d3c7-f0a3-4413-988f-88676c6edd90"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8097), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("23785793-7153-4ea8-959b-75b1dd1058d4"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8219), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container" },
                    { new Guid("26017b55-e151-4fcb-903f-869e37280d10"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7935), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("27ff1d0e-78cd-43b1-aabb-217a7f8ef66b"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8074), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("2e447589-3a9e-47cd-8f16-fb00557c214c"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7888), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("2e6c70c8-bfd7-43a3-add3-4ac029e15e01"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8120), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container" },
                    { new Guid("32e2f7ce-79ef-4d0f-bfc6-f5e5992ba4b5"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8078), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("33af7bbc-ee14-49df-9b22-26863f3ae398"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8057), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "container" },
                    { new Guid("33d4250e-3a15-4f50-ad23-93215a3e6f5e"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8213), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "Portion" },
                    { new Guid("33e2a00f-16ab-464d-a657-861c8debd1ab"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8183), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "box" },
                    { new Guid("3b49c92a-e05a-417e-aef8-de7ed93254a4"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7912), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container" },
                    { new Guid("3e9fa89b-85f4-4b64-94d0-b51c9319b903"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8235), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("43831eb7-b7c2-4b53-a894-cf8f25e69b44"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8087), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "container" },
                    { new Guid("498c3345-c624-41c2-b3f2-938d9aa65ef4"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7901), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("49eea95b-19dd-4a65-a926-501867bfb143"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8037), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("5054ebbf-2281-43e4-9d62-d4e7ac7e7e8d"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8132), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("53eecfae-a5b2-416c-a84b-b738ff9b16c0"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8027), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion" },
                    { new Guid("54715365-fffc-4ecc-a54b-f74c2cfec74f"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7880), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "container" },
                    { new Guid("547798f8-0ae0-475e-a84a-9f59b8271125"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8090), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "container" },
                    { new Guid("5a154f2e-df39-46ac-a8f5-caa93e7778c3"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7898), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("5b4e96e8-33a3-45fc-be5b-6d7698a1b49e"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7884), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion" },
                    { new Guid("5ba40044-f828-4b4a-b469-3e1326557046"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8142), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("5c508ac5-c177-462e-a69a-f85cdd1ebd56"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8109), 6f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("5f60c876-2107-4b16-8759-4e62bfb3ed1c"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7877), 22f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "container" },
                    { new Guid("6a36f054-a5cd-408c-bc35-b42d6a3a0d9c"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8051), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "box" },
                    { new Guid("6caaec5a-fb3f-4e77-8108-5bb5141daedc"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8104), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("6f5c7d4a-1115-439c-a469-821c0b855041"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8041), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("6f62e49c-3e0b-411b-b508-20b7f4e43695"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8186), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "container" },
                    { new Guid("75719b02-5793-46ef-9a36-71445d9613ac"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8210), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("75929458-88fb-4640-86e4-a47f46037f2b"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7905), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "Portion" },
                    { new Guid("7b250f51-07ff-4ba7-bb25-f67a4fce9380"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8071), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("81529b82-80ba-4e1c-b02b-5f06c9ecd900"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7895), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("83293a19-ce47-49d7-a6cf-764194067d29"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8113), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "Portion" },
                    { new Guid("83ac0da9-102f-4071-94f8-2df14fc83f4e"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8123), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "container" },
                    { new Guid("886aba3c-a405-49b9-9c75-59f6d848dd38"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7928), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("8f95f76c-2db3-4867-81e3-14113d45939c"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7868), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "Portion" },
                    { new Guid("9f9c1a32-9c21-43c8-8f8d-299139c45903"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8226), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "portion" },
                    { new Guid("a1ab2bab-bfeb-46d6-a050-62a1566957c3"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7922), 6f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("a53b3bb1-2933-42ec-938f-a2d4943c2312"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8135), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("a6de214e-28f2-45f6-b12f-45aa111c6b6e"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7942), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "box" },
                    { new Guid("a7c9eb51-1aff-4412-aba6-471ba4f58878"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7890), 6f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("abf1e5bd-b1fc-48c2-bd85-9b53dad59508"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7949), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "container" },
                    { new Guid("ade6547e-8d0d-4afe-8c38-bd5b279087aa"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8233), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("aed92e48-c086-4992-88a5-5f73acc2b514"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8116), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "box" },
                    { new Guid("b06632f3-8510-4081-876e-5740f5c21a77"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8190), 9f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "container" },
                    { new Guid("b0b0ab28-d775-46e2-add1-2485b4fb82ed"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7915), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "container" },
                    { new Guid("b25b831a-9d82-426a-88a6-d8b705aae0f8"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8068), 22f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("b54f1ba1-6704-4132-8468-14ac12db4997"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8083), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "box" },
                    { new Guid("b71cdc6b-a803-4bac-a720-a799a1795d39"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8054), 6f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container" },
                    { new Guid("bb9c7577-cbe6-4ed5-9c61-75ec974efcae"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8217), 22f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "box" },
                    { new Guid("c503bb83-d842-49ff-a3c3-23fcc767e37d"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7925), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("c7b9c3ea-4905-450a-a0ef-b34ea667bf32"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8196), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("c898db49-ed52-4a1e-bd18-44225411000f"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8080), 6f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "Portion" },
                    { new Guid("cd9d02c1-9b86-4de8-a4ce-071013145373"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8106), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("ce41498c-0aad-4628-9346-9452a5a46c7e"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8030), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("cf90266b-5ab5-4710-b083-a4d4b7a00541"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8064), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("dc7df4e7-7a8f-4e3d-9bb2-b70f2a8adea7"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8200), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("df9a0d7b-fcec-4583-8d93-a8fff3029b9d"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8139), 6f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("e1f1443e-9ef0-4b6a-839d-5d789c8271b3"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8094), 6f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion" },
                    { new Guid("eaaeec1e-6937-44dd-85dd-3715371dee47"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7872), 22f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "box" },
                    { new Guid("eee9902d-2a77-4b35-a95b-26364a5770ae"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8238), 6f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("f1343c33-6522-4058-ae49-13b4f76806a9"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8203), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("f38ea7d1-94fd-4dd9-8c1f-fa2ad045d7f5"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(7918), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "portion" },
                    { new Guid("f5d577d4-6f6f-4f5b-850f-215ba5dc16ec"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8047), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "Portion" },
                    { new Guid("f6ef8028-5f20-40ef-84a6-5bc87eee183d"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8192), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion" },
                    { new Guid("faca0b66-c598-4624-a500-bbb4f269df7e"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8125), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "portion" },
                    { new Guid("ff993549-f5b9-4c24-9809-7ac8b19a5d11"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8242), 9f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" }
                });

            migrationBuilder.InsertData(
                table: "StockOrders",
                columns: new[] { "Id", "CreatedAt", "OrderDate", "Quantity", "RestaurantId", "RestaurantItemId", "SupplierId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("03da8030-7ed4-4b98-9483-e7709bf8daf6"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8692), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8692), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8692) },
                    { new Guid("03fb480d-3108-4afa-a098-0716df344b7e"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8873), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8873), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8873) },
                    { new Guid("078e303c-afaf-44e6-bfd5-684094351831"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8828), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8828), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8828) },
                    { new Guid("08c7172f-bd10-4ac6-921e-d067ea7e9373"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8642), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8642), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8642) },
                    { new Guid("096ef13d-25b7-4b98-a240-f204eedb6551"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8877), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8877), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8877) },
                    { new Guid("0b4cbd43-b0d2-4203-b946-638955854070"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8663), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8663), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8663) },
                    { new Guid("0be505cf-e0be-4954-9f90-fbdcb292e96b"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8590), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8590), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8590) },
                    { new Guid("14561758-d765-4607-b0e9-d025b365f2eb"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8819), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8819), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8819) },
                    { new Guid("149352ab-38cb-41a9-a559-f0dd274d3ea0"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8611), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8611), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8611) },
                    { new Guid("1858040b-78ef-4ac5-a660-c20ad8fcc04a"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8656), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8656), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8656) },
                    { new Guid("1b067a13-9187-4aee-9f9a-abd5acb7e080"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8732), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8732), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8732) },
                    { new Guid("22faa7f4-baec-454f-b0b0-dbb7c6f0f5ce"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8719), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8719), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8719) },
                    { new Guid("23b554d5-5236-4a8c-9fdf-51c1c2f5bf15"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8649), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8649), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8649) },
                    { new Guid("249427dd-af3d-4c93-8f69-7e8991745f54"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8699), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8699) },
                    { new Guid("29727ed1-db12-44ec-a783-3f591642495f"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8868), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8868), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8868) },
                    { new Guid("2e6adb6c-0e00-467d-ac50-4ba01fb4177b"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8601), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8601), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8601) },
                    { new Guid("2f3b1b69-bf90-4d88-b546-013830e91ad2"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8793), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8793), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8793) },
                    { new Guid("35168a0d-a794-47a9-a06e-61468db72619"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8737), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8737), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8737) },
                    { new Guid("3dbb889c-a776-4e5c-9db9-a469c9d4d98a"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8593), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8593), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8593) },
                    { new Guid("3e6b3b1e-5c46-4a8c-a962-0bf0c1354f7d"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8637), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8637), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8637) },
                    { new Guid("3ea76b3b-be13-49ae-8b70-c8a0731f4c67"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8694), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8694), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8694) },
                    { new Guid("3eff6f45-37c3-42fa-8298-9bd92cc86d14"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8796), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8796), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8796) },
                    { new Guid("3f813e04-42ee-489e-8f83-017c4624c867"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8790), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8790), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8790) },
                    { new Guid("465a7c2d-2146-45fe-bdd6-35d6cbe78026"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8673), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8673), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8673) },
                    { new Guid("46d625f7-98c5-48a0-8961-af76ef492838"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8809), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8809), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8809) },
                    { new Guid("48eb6ed3-00a0-4b95-916e-3c9462712012"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8821), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8821), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8821) },
                    { new Guid("4de046d7-741d-4c9e-8d6a-a5b5b6e10c0e"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8712), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8712), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8712) },
                    { new Guid("4dfec224-9ed4-485d-9878-377178a6eb7b"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8640), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8640), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8640) },
                    { new Guid("58029282-8879-4bcf-b77c-5a13cca7f82a"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8585), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8585), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8585) },
                    { new Guid("5963987c-5a00-4cb8-a888-91e6bb0088a8"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8746), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8746), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8746) },
                    { new Guid("5b20eb99-18ba-41cf-8102-a55dc6371deb"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8608), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8608), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8608) },
                    { new Guid("5b3d3d02-1d3f-48d4-bf4a-02c7eb6edeb2"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8864), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8864), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8864) },
                    { new Guid("5b5af86c-0a05-4b25-bd82-81a22555975f"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8666), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8666), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8666) },
                    { new Guid("5e9323ad-de90-4fc1-9100-ecd50deb4c84"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8615), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8615), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8615) },
                    { new Guid("694113c7-c8de-456c-9368-4c41b2b4a345"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8741), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8741), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8741) },
                    { new Guid("6a54661c-a33a-4dfa-856a-3b7220d8de05"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8855), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8855), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8855) },
                    { new Guid("6adfbdf1-d6ed-4f7c-b766-36c1a132df3c"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8852), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8852), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8852) },
                    { new Guid("6c299efa-7ab8-4365-86c7-def8134408a6"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8861), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8861), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8861) },
                    { new Guid("758ec757-a852-475f-987e-773c8a44796a"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8843), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8843), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8843) },
                    { new Guid("777cc918-5502-4915-8a75-f92a415cb6a4"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8774), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8774), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8774) },
                    { new Guid("7d32f672-c927-4734-9c76-9a84046518ef"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8646), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8646), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8646) },
                    { new Guid("7e0f3b0d-10fe-4bf1-b73e-a3eba780d4a7"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8826), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8826), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8826) },
                    { new Guid("80eb6704-d4f2-46e3-8f1d-7f27bb20a0b0"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8832), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8832), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8832) },
                    { new Guid("8528cee4-c233-4d53-8cd0-4e6a3a97997d"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8812), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8812), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8812) },
                    { new Guid("89b7290d-782a-4eab-ab0f-00c3d8407a7b"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8604), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8604), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8604) },
                    { new Guid("8c96304b-b848-4c39-a3f4-8e7974feac55"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8682), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8682), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8682) },
                    { new Guid("8cb806b8-b095-4080-858b-f9c539fcc91c"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8721), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8721), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8721) },
                    { new Guid("8f35a003-cfc9-4d8a-8e0a-7f2bcd2a02b5"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8659), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8659), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8659) },
                    { new Guid("8f8464a8-d3a5-4ced-811d-9e8167b2c6b3"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8728), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8728), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8728) },
                    { new Guid("965bdcf1-9fee-4390-bf55-972ec8747fe5"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8689), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8689), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8689) },
                    { new Guid("9683ebc7-054e-46ef-af78-9ad9a08b8f1e"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8884), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8884), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8884) },
                    { new Guid("a2703538-fc75-44ef-986a-ca5f3254facb"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8848), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8848), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8848) },
                    { new Guid("a3283973-4288-4beb-acac-6e00dce257cb"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8807), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8807), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8807) },
                    { new Guid("b0ff6dab-6a23-4f89-85f5-a2a9a979b098"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8669), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8669), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8669) },
                    { new Guid("b1698825-266b-4cee-8c00-33d3ac54863a"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8845), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8845), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8845) },
                    { new Guid("b3fe3234-765b-45d1-be39-19ab55ee7e8e"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8685), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8685), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8685) },
                    { new Guid("b4169bbe-932e-4cf4-baff-ed61c2e4b8b6"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8786), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8786), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8786) },
                    { new Guid("b6390b59-eddf-4a10-b07c-7d62535e2404"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8839), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8839), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8839) },
                    { new Guid("ba20056b-ce5b-4d8e-8c45-b06566626a66"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8777), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8777), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8777) },
                    { new Guid("ba3de75b-0c82-4af3-87f3-5729824159e8"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8576), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8576), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8576) },
                    { new Guid("bc9d528e-b80e-41b4-897e-eb6fb8a61c78"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8701), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8701), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8701) },
                    { new Guid("c22f5db9-280b-4902-b2cd-83edd37a1673"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8680), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8680), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8680) },
                    { new Guid("c3fee724-d67a-4b51-83d2-0b0e414bde87"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8705), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8705), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8705) },
                    { new Guid("c4d53456-7dc7-4d50-97bb-d65f6596d941"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8816), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8816), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8816) },
                    { new Guid("c6c1a1db-797d-4344-9bb8-a7ecbb4ed480"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8595), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8595), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 18, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8595) },
                    { new Guid("cf6a07bc-6172-4739-9d21-db1f825c9b0d"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8734), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8734), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8734) },
                    { new Guid("d01a8ed3-6ca9-47fb-92cf-304b006aaf09"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8859), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8859), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8859) },
                    { new Guid("d69a7518-b291-476d-82d0-880c703e2ed8"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8781), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8781), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8781) },
                    { new Guid("d860ba10-ce4a-41e4-90b2-6b1781bacb52"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8708), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8708), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8708) },
                    { new Guid("da0639ba-6950-41d8-a935-8ffaff402a36"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8725), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8725), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8725) },
                    { new Guid("e26f3905-2686-4743-a703-0a13fda6f49e"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8880), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8880), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8880) },
                    { new Guid("e2d399a7-7ef9-4797-9e89-f282a370c3d5"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8835), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8835), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 12, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8835) },
                    { new Guid("ea42400f-8fe0-4591-a518-1df0b13a0e89"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8716), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8716), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 15, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8716) },
                    { new Guid("eb97f77a-4ad1-4ed6-8b60-6ed93d09a8cd"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8653), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8653), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 17, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8653) },
                    { new Guid("f06ca1c1-ea9a-4e10-8e48-9e62167252c0"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8676), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8676), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 16, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8676) },
                    { new Guid("f4366bc2-a327-4f71-b52b-8b1d1ce0c0bb"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8803), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8803), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8803) },
                    { new Guid("f69884d8-7c1a-4ed0-bcab-9383839e7831"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8744), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8744), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8744) },
                    { new Guid("fa3e1552-e2cc-4961-a2ee-6ca257923b58"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8800), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8800), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 13, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8800) },
                    { new Guid("ff7b7fb0-bbad-40f2-abe3-dbe9a666b772"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8784), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8784), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 14, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8784) },
                    { new Guid("ff885fde-7720-40dc-82ce-e68079d52396"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8870), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8870), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 11, 1, 44, 55, 200, DateTimeKind.Local).AddTicks(8870) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BudgetExpenses_RestaurantId",
                table: "BudgetExpenses",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Budgets_BudgetCategoryId",
                table: "Budgets",
                column: "BudgetCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Budgets_RestaurantId",
                table: "Budgets",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ExpenseTypeId",
                table: "Expenses",
                column: "ExpenseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_RestaurantId",
                table: "Expenses",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryAlerts_RestaurantItemId",
                table: "InventoryAlerts",
                column: "RestaurantItemId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryReports_RestaurantId",
                table: "InventoryReports",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantInventories_RestaurantId",
                table: "RestaurantInventories",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantInventories_RestaurantItemId",
                table: "RestaurantInventories",
                column: "RestaurantItemId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantInventories_SupplierId",
                table: "RestaurantInventories",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantItems_ItemLocationId",
                table: "RestaurantItems",
                column: "ItemLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantItems_RestaurantId",
                table: "RestaurantItems",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantItems_SupplierId",
                table: "RestaurantItems",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RestaurantId",
                table: "Reviews",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_StockOrders_RestaurantId",
                table: "StockOrders",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_StockOrders_RestaurantItemId",
                table: "StockOrders",
                column: "RestaurantItemId");

            migrationBuilder.CreateIndex(
                name: "IX_StockOrders_SupplierId",
                table: "StockOrders",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierInventories_SupplierId",
                table: "SupplierInventories",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierInventories_SupplierItemId",
                table: "SupplierInventories",
                column: "SupplierItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierItems_SupplierId",
                table: "SupplierItems",
                column: "SupplierId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlertRecipients");

            migrationBuilder.DropTable(
                name: "Budgets");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "InventoryAlerts");

            migrationBuilder.DropTable(
                name: "InventoryReports");

            migrationBuilder.DropTable(
                name: "RestaurantInventories");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "StockOrders");

            migrationBuilder.DropTable(
                name: "SupplierInventories");

            migrationBuilder.DropTable(
                name: "BudgetExpenses");

            migrationBuilder.DropTable(
                name: "RestaurantItems");

            migrationBuilder.DropTable(
                name: "SupplierItems");

            migrationBuilder.DropTable(
                name: "ItemLocations");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
