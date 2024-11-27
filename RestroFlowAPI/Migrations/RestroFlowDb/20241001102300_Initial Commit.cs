using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestroFlowAPI.Migrations.RestroFlowDb
{
    /// <inheritdoc />
    public partial class InitialCommit : Migration
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
                name: "ExpenseReports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalExpenses = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LaborCosts = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Utilities = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MiscellaneousExpenses = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HighestExpenseCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LowestExpenseCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpenseReports_Restaurants_RestaurantId",
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
                    { new Guid("251f81fe-8506-4980-9a6c-c2997b8619a9"), new Guid("21804e79-b2bb-4a6e-9418-3cab51e579ac") },
                    { new Guid("acd23698-1ded-4769-aabc-63fbfb1e7503"), new Guid("f2ba15e2-f1d3-43d1-bb84-6767253ebbe2") },
                    { new Guid("b77d9b82-edf3-49c8-9cc8-a72bd43ddf52"), new Guid("36c8f410-61d4-49fb-beb0-ff35e319614e") },
                    { new Guid("d683c0dd-606e-4c7a-a5f4-eb1aab9b672a"), new Guid("9125374f-e121-40f2-b42f-089529dd5fbd") }
                });

            migrationBuilder.InsertData(
                table: "ItemLocations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("450b39b8-feac-40df-b0fe-4cf56b19cefb"), "Back of House Stock Lists" },
                    { new Guid("65d495da-2dca-4c41-8501-334372440ada"), "Front of House Stock Lists" }
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
                    { new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "88 Kangaroo Court", " Brisbane", " JamesCooper@FFI.com", "James Cooper", "08 9314 7890", new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(44), "Fresh Food Industries", "VIC", new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(46) },
                    { new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "23 Sunset Avenue", "Fremantle", "OliviaMiller@GFIFood.com", "Olivia Miller", "03 6234 9087", new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(49), "GFI Foods", "VIC", new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(51) },
                    { new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "45 Maple Street", "South Yarra", "SarahJohnso@CFS.com", "Sarah Johnso", "07 3345 6721", new DateTime(2024, 10, 1, 20, 22, 59, 801, DateTimeKind.Local).AddTicks(9658), "Complete Food Services", "VIC", new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(37) }
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
                    { new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(3375), null, new Guid("450b39b8-feac-40df-b0fe-4cf56b19cefb"), "Chicken wings", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(3377) },
                    { new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(3365), null, new Guid("450b39b8-feac-40df-b0fe-4cf56b19cefb"), "Boneless chicken", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "box", new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(3371) },
                    { new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(3404), null, new Guid("65d495da-2dca-4c41-8501-334372440ada"), "Spicy sauce", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(3406) },
                    { new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(3411), null, new Guid("65d495da-2dca-4c41-8501-334372440ada"), "Sweet Chiilies", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(3412) },
                    { new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(3389), null, new Guid("450b39b8-feac-40df-b0fe-4cf56b19cefb"), "Marinated beef", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion", new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(3390) },
                    { new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(3416), null, new Guid("65d495da-2dca-4c41-8501-334372440ada"), "Wedges", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(3417) },
                    { new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(3394), null, new Guid("65d495da-2dca-4c41-8501-334372440ada"), "Chicken powder", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(3396) },
                    { new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(2480), null, new Guid("450b39b8-feac-40df-b0fe-4cf56b19cefb"), "Whole chicken", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "Portion", new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(2622) },
                    { new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(3381), null, new Guid("450b39b8-feac-40df-b0fe-4cf56b19cefb"), "Chicken Steak", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(3382) },
                    { new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(3399), null, new Guid("65d495da-2dca-4c41-8501-334372440ada"), "Soy garlic", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 1, 20, 22, 59, 802, DateTimeKind.Local).AddTicks(3401) }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Rating", "RestaurantId", "ReviewContent", "ReviewDate", "ReviewSource" },
                values: new object[,]
                {
                    { new Guid("02cdd1d2-2f33-44e7-90ac-effa100767cf"), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3319), "Others" },
                    { new Guid("0fddcaf3-4535-4aed-adfe-212429a40242"), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3324), "Facebook" },
                    { new Guid("15c407f5-3af9-45a3-bd2d-b6bb39c38164"), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3377), "Facebook" },
                    { new Guid("2f951159-35c8-4a8f-bafe-f5022612e217"), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3315), "Facebook" },
                    { new Guid("3be32d98-87a7-4998-a321-b775dec4922a"), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3363), "Facebook" },
                    { new Guid("3c713590-e880-4cf5-b388-b0cb18a4b0f9"), 2f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3384), "Facebook" },
                    { new Guid("46f2dd42-0f3d-4b8b-8ea1-531d4ec17db8"), 2f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3330), "Google" },
                    { new Guid("65111ef9-6394-4da2-acc1-eaee4a72e989"), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3306), "Others" },
                    { new Guid("7c9766f6-88ef-4127-b91a-8e257466c1ee"), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3372), "Instagram" },
                    { new Guid("bb0ea11a-3185-4cf9-9a62-c044abd2ca88"), 2f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3368), "Instagram" }
                });

            migrationBuilder.InsertData(
                table: "SupplierItems",
                columns: new[] { "Id", "CreateAt", "Description", "Name", "Price", "SupplierId", "Unit", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0c9d1223-87a9-4a8b-98dd-4b02e60d253f"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3996), null, "White radish", 25m, new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "container", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3997) },
                    { new Guid("152e6d2f-eace-443a-bc98-91adde8e0b9b"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4297), null, "Hotteok", 34m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "pack", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4299) },
                    { new Guid("2194b08f-39d2-4ccf-82bf-c7094ae505e5"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3962), null, "Chicken powder", 17.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3963) },
                    { new Guid("29a17c4b-29be-4d3f-8d4e-8333debe38e6"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4188), null, "Milk", 19.9m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "carton", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4189) },
                    { new Guid("30d83082-69d9-4734-a7b7-1b79ff889cf9"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4193), null, "Potato noodle", 50m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "box", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4194) },
                    { new Guid("3a3721cf-4845-4f57-84db-60d48dcbb1ab"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4114), null, "Beef dashida", 30.2m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4116) },
                    { new Guid("3b5b7483-1eec-4b36-895a-2ab57b17b493"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4012), null, "Spicy sauce", 34m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4014) },
                    { new Guid("3d623e41-232e-41cf-a1cb-d2a0aff4c518"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4204), null, "Fish cake", 21m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4205) },
                    { new Guid("3f35c382-03ae-4d36-a1eb-3918b8180ebe"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4028), null, "Chicken steak", 10m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4030) },
                    { new Guid("43aa51c9-8436-4aa7-9e2d-f214c0d25585"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4291), null, "Japchae mandu", 30.2m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "pack", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4292) },
                    { new Guid("467da1ff-479d-44a3-a831-85f908130d3d"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4056), null, "Wedges", 50m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4058) },
                    { new Guid("48fa9242-0766-45ee-b34c-24fba4c814e8"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4044), null, "Pancake mix", 50m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4046) },
                    { new Guid("4c0b63fc-de46-4a4a-8af3-2413772ba74d"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4302), null, "K-donut", 10m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "pack", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4303) },
                    { new Guid("4f9b74c7-7610-4934-beb2-32cb2f744ded"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4099), null, "Seasame oil", 11m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "can", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4100) },
                    { new Guid("56207525-d0a7-407a-aa5c-38ba3d7ee93f"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4040), null, "Corn kernel", 20.5m, new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4041) },
                    { new Guid("5b71b923-c74b-4cfd-a9b6-4a7b4983208c"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4076), null, "Chips", 10m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4078) },
                    { new Guid("5ec1e53d-8edf-453e-a573-8aa1013b09ee"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4256), null, "Salted butter", 11m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "pack", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4257) },
                    { new Guid("5f4e6045-a162-4d55-a17e-b540b0883e00"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3983), null, "Boneless Chicken", 30.2m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "box", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3985) },
                    { new Guid("5f9a7cb6-4419-42f1-80b5-dcbb993f004e"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4182), null, "Eggs", 10m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "dozen", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4183) },
                    { new Guid("64174eee-f638-47c8-8779-e688f1666c97"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4165), null, "Carrot rings", 21m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "pack", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4166) },
                    { new Guid("6c3f2f08-5a00-41ae-9c04-8d7be61d24d9"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4199), null, "Mayonnaise", 17.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bucket", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4201) },
                    { new Guid("6cc7f1f5-995d-476d-ad98-3e2620aec13f"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4250), null, "Crushed garlic", 13.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bucket", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4251) },
                    { new Guid("6d752fbd-f814-4885-966e-baf40da2917e"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4017), null, "Mix salad", 34m, new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "box", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4019) },
                    { new Guid("6df3ad11-64d4-4b20-a22e-54e9694129f2"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4230), null, "Slider bun", 11m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4231) },
                    { new Guid("6fa13f9e-8623-4948-88b2-a557fde31367"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4241), null, "Gochujang sauce", 13.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4242) },
                    { new Guid("72974c85-8481-44e0-9a04-76aa863249aa"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4282), null, "Prawn mandu", 22m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "pack", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4283) },
                    { new Guid("7d58fc04-e56b-4309-8b08-a771ef92285e"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4224), null, "Burger bun", 17.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4225) },
                    { new Guid("8540cd17-28fc-4973-ac63-a068862ca35d"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4149), null, "Boxing wings", 20.5m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4150) },
                    { new Guid("88c191a6-015f-4450-b2fc-9334a1701074"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4287), null, "Prawn burger", 25m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "pack", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4288) },
                    { new Guid("8abac914-2b8e-48ec-8fb3-c975197c6965"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4219), null, "Mozzarella cheese", 20.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4221) },
                    { new Guid("8befd094-3905-4364-a431-ae8d506ae841"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4172), null, "Ketchup", 10m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "gallon", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4174) },
                    { new Guid("8f572af0-7c09-4ecf-9013-a00ec2092dc4"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4245), null, "Tteokbokki sauce", 17.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4247) },
                    { new Guid("8f7d0d64-7adb-4075-b096-f4585b91efc9"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4235), null, "Red spicy mayo", 34m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4236) },
                    { new Guid("8fe01fe4-8985-473a-bfb2-6e837e2e423f"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3949), null, "Whole chicken", 10m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "pack", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3951) },
                    { new Guid("913943d7-89c2-494f-a2b4-d7d49032ea00"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4049), null, "Marinated beef", 13.5m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4050) },
                    { new Guid("9ac0dfa3-f8c3-4775-b0b5-8b293b81458f"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4177), null, "Thai sweet chilli", 11m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "gallon", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4179) },
                    { new Guid("a0c208be-e2e9-462e-8c23-fc7ea921ba31"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4005), null, "Chicken wings", 50m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4007) },
                    { new Guid("a0faa1ee-6820-4fa0-93c1-7af73099370e"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3976), null, "Instant noodle", 34m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "pack", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3978) },
                    { new Guid("a2c7d764-6fb5-4016-83c0-9a28bb9a2da4"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4065), null, "Dumpling", 34m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4067) },
                    { new Guid("a4021320-8023-4af8-af58-194ccade13fc"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4087), null, "Skewers", 21m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4089) },
                    { new Guid("a43eb14c-56e5-479d-b9bb-a45a26c1393a"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4261), null, "Cheese sauce", 34m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4262) },
                    { new Guid("a93cb771-e50c-4b0a-84fd-b19df7379331"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4271), null, "Whole gain mustard", 30.9m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "tub", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4273) },
                    { new Guid("a9c7b02b-077b-43e2-a26d-934cf4d6c7a6"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4061), null, "Dried garlic", 50m, new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "container", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4062) },
                    { new Guid("abcac941-264f-4833-8441-bc2e55da2c39"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3989), null, "Soy garlic", 19.9m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3991) },
                    { new Guid("aec2b83e-cb0f-4492-a4db-b86019355751"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4276), null, "Tomato Relish", 30.2m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bottle", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4277) },
                    { new Guid("b8447c20-cd7f-456b-8a26-ea1b826e4cf5"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4208), null, "Sour cream", 50m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "tub", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4210) },
                    { new Guid("ba59b618-74ee-4b05-86d9-3f97fc92c4df"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4108), null, "Corn ribs", 20.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "pack", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4109) },
                    { new Guid("c14361d7-1f6b-4e5d-af29-21b58e0e59d4"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4092), null, "Shoestring chips", 10m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4093) },
                    { new Guid("c2a0761e-67d6-4b96-bac2-66c53ec4855e"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3969), null, "Coleslaw", 20.5m, new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3971) },
                    { new Guid("cf04f89c-89d7-4405-815f-1cf42ef4f395"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4103), null, "Boiled gochujang", 50m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4104) },
                    { new Guid("d3276f25-6ead-4aee-82b5-ff99515f7ec1"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4072), null, "Drumstick", 17.5m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4073) },
                    { new Guid("d6893452-498e-4e56-ae2f-a5c6d41b8dc5"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4022), null, "Frying mix", 17.5m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4023) },
                    { new Guid("d868b2b8-4db8-4624-963f-1661e8cb906b"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4033), null, "Sweet chillies", 30.9m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4035) },
                    { new Guid("e005bb76-89aa-4705-8dfe-7d43faeb922b"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4160), null, "Kimchi", 25m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "container", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4162) },
                    { new Guid("e307d374-7b4b-413e-b3c6-8e03e2085521"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4265), null, "Potato flake", 17.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4266) },
                    { new Guid("e3ed00bd-71f7-4f80-90f7-7aa84a960cd6"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4083), null, "Corn syrup", 25m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "gallon", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4084) },
                    { new Guid("e4618c71-ec46-4798-b16c-250fd2b6c805"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4001), null, "Rice cake", 30.9m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4002) },
                    { new Guid("e5e4c660-5195-4a71-8d6e-133b25198454"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4215), null, "Soy sauce", 13.5m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "jerrycan", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4216) },
                    { new Guid("f3ab5716-3352-46f3-82c1-6e8fd306fd63"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4156), null, "Mustard", 50m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "", new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(4157) }
                });

            migrationBuilder.InsertData(
                table: "Budgets",
                columns: new[] { "Id", "BudgetAmount", "BudgetCategoryId", "BudgetEndDate", "BudgetStartDate", "CreatedAt", "Description", "RestaurantId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("53a96add-b06b-44df-b687-89ac6aaf609b"), 1000m, new Guid("d9b33212-dc51-4174-8e9d-299858f0ea88"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3274), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3272), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eae94a71-8307-4ea2-aaf1-5be79338bf07"), 2000m, new Guid("a57b3ede-7810-44d9-9f73-04dfa330a971"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3268), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3266), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Amount", "ExpenseDate", "ExpenseTypeId", "RestaurantId" },
                values: new object[,]
                {
                    { new Guid("20502e61-b5a1-4b83-bb8e-12fea1400c0b"), 250m, new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2534), new Guid("d9b33212-dc51-4174-8e9d-299858f0ea88"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("221a801b-ff21-4224-b32a-04855ac4faf0"), 80m, new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2493), new Guid("d9b33212-dc51-4174-8e9d-299858f0ea88"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("28c0b60c-8af4-45d3-8051-5decffef91a0"), 80m, new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2538), new Guid("a57b3ede-7810-44d9-9f73-04dfa330a971"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("349196d5-c440-4a2b-8acb-49c3f5d21e92"), 250m, new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2529), new Guid("a57b3ede-7810-44d9-9f73-04dfa330a971"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("34b1a18f-cbb0-49ba-b0aa-e38a58cb7c09"), 100m, new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2560), new Guid("d9b33212-dc51-4174-8e9d-299858f0ea88"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("3861e6c4-9997-45da-86e8-25d04eee53f8"), 120m, new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2542), new Guid("d9b33212-dc51-4174-8e9d-299858f0ea88"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("65bef88c-207a-4d56-beda-ac1fe67f2d9e"), 80m, new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2520), new Guid("a57b3ede-7810-44d9-9f73-04dfa330a971"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("9566ecc0-956d-42f6-9410-453d390821b3"), 250m, new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2569), new Guid("d9b33212-dc51-4174-8e9d-299858f0ea88"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("9a4316e3-d847-4e12-904c-6f45a3f42efc"), 80m, new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2525), new Guid("d9b33212-dc51-4174-8e9d-299858f0ea88"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("a3b7de98-7618-44c6-89fd-30383c121af4"), 120m, new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2557), new Guid("a57b3ede-7810-44d9-9f73-04dfa330a971"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("a4a52c40-1135-4c2f-bc38-41771f09c68d"), 120m, new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2548), new Guid("a57b3ede-7810-44d9-9f73-04dfa330a971"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("a98b865a-aac1-4b1b-a16d-5193383f09c1"), 100m, new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2510), new Guid("a57b3ede-7810-44d9-9f73-04dfa330a971"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("bcca48b4-9dd4-4035-ba8f-cc0ef01b103b"), 100m, new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2446), new Guid("a57b3ede-7810-44d9-9f73-04dfa330a971"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("e16df182-e1de-45ff-b769-1d05821b2337"), 80m, new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2564), new Guid("a57b3ede-7810-44d9-9f73-04dfa330a971"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("f56c7587-9df8-461b-afa6-ffee82b4f70c"), 80m, new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2551), new Guid("d9b33212-dc51-4174-8e9d-299858f0ea88"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("fbb29493-9649-4193-a83b-a200ed62dbaf"), 120m, new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2514), new Guid("d9b33212-dc51-4174-8e9d-299858f0ea88"), new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") }
                });

            migrationBuilder.InsertData(
                table: "InventoryAlerts",
                columns: new[] { "Id", "CreatedAt", "RestaurantItemId", "Threshold", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("155ce716-0a92-4f3b-a39f-3aa1b5126fd0"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3208), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), 8f, new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3209) },
                    { new Guid("70b90444-a7b9-482b-a382-464ab9778f8f"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3193), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), 3f, new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3195) },
                    { new Guid("8f53f8fa-f5fb-42d0-81ce-58a5d67fe37c"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3188), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), 8f, new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3189) },
                    { new Guid("9a810013-aaaf-4999-ae95-5af6afad186a"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3177), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), 8f, new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3179) },
                    { new Guid("b96733fe-0fb9-426a-8a48-b464e987f065"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3163), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), 5f, new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3165) },
                    { new Guid("bbd1f37d-e4e3-499d-a7ae-1c7c906e8294"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3182), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), 20f, new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3183) },
                    { new Guid("d482cf28-39ba-4c8b-9ddd-17328fcfcb7a"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3197), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), 20f, new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3199) },
                    { new Guid("dc6487da-2e65-45f2-9cfe-9295b0f60bea"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3213), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), 9f, new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3214) },
                    { new Guid("e5cf5140-c5d7-4cf0-94f4-b379ea3ab3da"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3203), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), 25f, new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3205) },
                    { new Guid("ef392384-a9cf-4240-9689-d2af1325596e"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3171), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), 3f, new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3172) }
                });

            migrationBuilder.InsertData(
                table: "RestaurantInventories",
                columns: new[] { "Id", "LastUdpated", "Quantity", "RestaurantId", "RestaurantItemId", "SupplierId", "Unit" },
                values: new object[,]
                {
                    { new Guid("04422ed6-44b9-4002-987a-b0cc09564411"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2818), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("07af08c1-efff-48f2-bc44-6de9f817eeae"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2726), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "portion" },
                    { new Guid("0916af67-dd0d-4541-a1f6-5ea6837cbdbe"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2955), 9f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("093f72f5-6191-471d-8ab6-387761d42ab0"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2739), 9f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("0fb6860e-4f7d-4d62-aa5d-656c485fc0f8"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2720), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container" },
                    { new Guid("0fe8b907-d937-46c5-a5cc-e5cb98ece79e"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2928), 9f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("110ed2a8-6c40-4025-8c31-6381baf6b8f0"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2944), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "container" },
                    { new Guid("11e8d882-dae0-49e6-90af-cf76237d5d1d"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2641), 9f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "box" },
                    { new Guid("1448744b-03f2-4fa2-a219-33cf9712e8cc"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2690), 22f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("166cef17-2dfd-4482-84bc-015afcd621fe"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2893), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "Portion" },
                    { new Guid("17f2ad09-9fc8-45ce-ae1b-e33023cd1681"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2932), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "Portion" },
                    { new Guid("1d18a5b4-2b73-409b-b402-b227892bb341"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2680), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "container" },
                    { new Guid("20efd270-3c31-42e2-b77e-bec05302a0a4"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2698), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("2356463a-b0ec-4839-82af-002b553c4ab1"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2702), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("2475d0fe-8345-4e0f-a1f1-601ff66c197b"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2978), 9f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "container" },
                    { new Guid("29127707-df69-42c0-945b-5d562b20d93b"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2958), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("2bcbec92-aabc-41c9-afa0-164781bfca47"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2983), 6f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "container" },
                    { new Guid("2c81fd78-1837-4162-97a6-4d9bddaed6de"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2952), 9f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("2ddc5417-0e39-4dd2-afe0-cdc1431d52da"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2731), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("3081415a-dd62-4785-a39e-2fb7a247a7ce"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2991), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("33d2e72b-02ba-402d-8210-e51f5db87070"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2786), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("33d81c7e-7fe3-4d64-9bf1-47a9a5227451"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3011), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "Portion" },
                    { new Guid("3d1c04b0-ebbb-4746-b0db-8164df4c4c4b"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2890), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("488374f9-1d15-407e-8278-46ac94861296"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2693), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("4cfa267a-5a94-4c91-a31b-fc8f5ea14786"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2924), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("4e76a809-2ad4-47e9-984c-94348738420f"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3023), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "container" },
                    { new Guid("503dd1c0-e646-4e3d-bbf9-1c57d67c3608"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2755), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "box" },
                    { new Guid("57142e7d-3acb-4fb3-b98b-909e08ac0112"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2963), 22f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("57a40b09-bd8d-4616-864f-9e9cb66a1fe5"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2807), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "portion" },
                    { new Guid("5922af00-b2c4-4250-b964-8febe0681b32"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2783), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("5c810782-f5ca-4f1e-8ef5-6809a62a8c17"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2916), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("5d59f7d5-ac94-4c02-9b5a-44c886466a70"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2744), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("5e7306ec-e7ae-47e0-b9d7-4ca35b1aac50"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2901), 22f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "container" },
                    { new Guid("63c6f178-891d-462f-84c9-30e3df58d5e7"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2715), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "box" },
                    { new Guid("67228449-d3ca-47d1-9271-cd42cbf637d8"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2967), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("68a99464-00a3-4256-af0c-50d3494d90de"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2913), 9f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("6cc6d58f-2cf8-492f-b750-c1a0814ad962"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2706), 9f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("7685831d-3ca8-41ce-a120-7e5e7c8f21f2"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2802), 6f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "container" },
                    { new Guid("788e1e9a-4779-48a7-ba1c-99a856138be9"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2778), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("791efa6f-def1-44f0-99a3-483f14c0f725"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2986), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion" },
                    { new Guid("7a44a6d9-a6d7-41cb-bb69-3b2b0c09a9e4"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2941), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container" },
                    { new Guid("7aa76762-d652-4e06-9583-f361edffad50"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2947), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "portion" },
                    { new Guid("7b1dd9ba-4575-4f18-8d73-ada9f021e228"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2636), 9f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "Portion" },
                    { new Guid("7e6c37ef-139b-4d7f-86b1-ddbfdfef7196"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2797), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container" },
                    { new Guid("83f6133d-30af-432b-b4ef-7d9461845cbd"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3089), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("8851beea-86cf-4757-be1a-8a6e166fcc6a"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3005), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("8b9835ee-016c-4e0e-b3ae-ddf9e7fc08e2"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2789), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "Portion" },
                    { new Guid("8d311b82-946e-4d2e-8f0e-1df471f89302"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2810), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("8df03dc7-ba66-4f1b-b658-833a552b08a8"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3077), 22f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("8e4a0f2d-2136-4849-b58e-4364ea2b4712"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2767), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion" },
                    { new Guid("8feef73b-47b9-4e05-9fd3-59e2bf65a36f"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2764), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "container" },
                    { new Guid("95ab21e3-1a1f-4f31-8a82-ef6449dc4eb3"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2815), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("9aaeb6b7-6f4b-400e-8b29-90a035c62793"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2723), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "container" },
                    { new Guid("9fb35e18-947c-46e8-84ae-4b4fa5b19336"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3016), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "box" },
                    { new Guid("a47a442e-53c7-409e-9d1a-923a4cb8f17c"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2905), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "container" },
                    { new Guid("a62a99fc-8669-4182-861e-359f0289e0de"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2747), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("a6cdc175-b3f6-47a2-ae16-538e52590473"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2686), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion" },
                    { new Guid("a756ec08-34ad-4693-8683-605d8ba95a34"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3072), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("a7aec241-14c0-4a5c-aab4-7750f522e081"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2711), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "Portion" },
                    { new Guid("ac4f1156-808f-4e1b-94fb-f5b80e1cfde9"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3084), 22f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("adb1e0e2-aabd-44d0-b603-5c5686460230"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2770), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("ae7fd0ad-cfb7-4590-bda4-3fea624de57f"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2794), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "box" },
                    { new Guid("b0a406fe-777d-4e94-8908-75493d4724a1"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2897), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "box" },
                    { new Guid("b0aaebe7-9d0c-4bf9-aca1-c4956c3b99de"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3019), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container" },
                    { new Guid("b1f19172-7ef9-4544-ba06-b2670648f563"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2759), 22f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "container" },
                    { new Guid("b99a4cf7-c75f-49c8-b4c3-8e1662ecb394"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2936), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "box" },
                    { new Guid("bc6bb4f9-701e-4c61-a809-d6dae94ce3f2"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2975), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "box" },
                    { new Guid("c1e30549-be4c-4115-bdc1-7da1cfa54509"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3080), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("c9dd64e0-6573-4d34-bf25-46c2fe4d6add"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2996), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("cd980b0e-6f55-4f05-bf3e-17261a3481ab"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3069), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "portion" },
                    { new Guid("d94c9647-3d4d-4100-abc1-2ae0371edc30"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3008), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("dd950109-955d-4135-a2ef-4b8ae2065a9e"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2775), 22f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("de46d212-8cca-4637-9cb6-1534a0a3f9e5"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2910), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion" },
                    { new Guid("dfc95dcc-32a6-4c68-a5da-8cb47394458f"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2972), 9f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "Portion" },
                    { new Guid("eafa419e-fc26-4e1a-a7aa-25c9478dfb30"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2676), 6f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "container" },
                    { new Guid("ed60a258-72d0-485f-8d4b-103abfd2b790"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2884), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("f0e8b143-d08e-49b8-bfc3-5ef7a0286f34"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3000), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("f5a0c189-214b-4001-9f57-46901079b531"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2735), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("fa7574d4-1974-470c-a52f-bd85ca7b17bf"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2921), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("ffae5051-2e3c-4fa3-87ea-c94e16eaf726"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(2752), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "Portion" }
                });

            migrationBuilder.InsertData(
                table: "StockOrders",
                columns: new[] { "Id", "CreatedAt", "OrderDate", "Quantity", "RestaurantId", "RestaurantItemId", "SupplierId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("02319853-e7ff-4297-90a5-be2e6d7087af"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3623), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3623), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3623) },
                    { new Guid("07bfac77-4644-4c56-be98-67470db446a9"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3628), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3628), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3628) },
                    { new Guid("0940c78f-cb0d-4c78-a5ed-7bf0a6c9f908"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3674), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3674), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3674) },
                    { new Guid("0b5bb09f-d72c-45dc-915a-d0d7f970768a"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3549), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3549), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3549) },
                    { new Guid("0f6f7ed6-c1af-4969-b285-8e2c2ceeb802"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3636), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3636), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3636) },
                    { new Guid("1371d148-4adc-497a-8704-44d79c160bd6"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3518), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3518), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3518) },
                    { new Guid("1a3df0ae-d260-4141-8677-009e7216565b"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3791), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3791), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3791) },
                    { new Guid("1c888869-4c6a-4c16-8ba5-c98c822b2132"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3704), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3704), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3704) },
                    { new Guid("1e51c95b-13eb-44d0-9dfa-bfc65122ec3c"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3819), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3819), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3819) },
                    { new Guid("1e9871db-ca6f-43b3-bf58-2acd07bf131c"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3535), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3535), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3535) },
                    { new Guid("1eaf9cbe-5491-4d0f-8efd-85a7412b686d"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3775), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3775), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3775) },
                    { new Guid("243d6c8e-ddcd-4933-9e02-6af17f0d4f05"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3511), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3511), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3511) },
                    { new Guid("2458c51d-715e-438a-907d-ee8c0e48e759"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3591), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3591), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3591) },
                    { new Guid("2654ac4d-3efd-43b5-a31b-5cd343bf2638"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3716), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3716), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3716) },
                    { new Guid("2a8fc0b5-6463-47ad-958f-e37b754e675c"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3698), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3698), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3698) },
                    { new Guid("306e0911-9215-4358-bcac-76d42c62543f"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3685), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3685), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3685) },
                    { new Guid("3454e45f-47a1-4441-b55b-5bd1b43d65db"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3763), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3763), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3763) },
                    { new Guid("39ca8c71-0b9e-4e1d-800c-fd32093bcbf5"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3514), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3514), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3514) },
                    { new Guid("3fcb877d-7218-42f6-85aa-8df690718f91"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3643), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3643), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3643) },
                    { new Guid("41eacdc8-8f87-4214-b4a3-7f88cf32c66c"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3503), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3503), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3503) },
                    { new Guid("45da5d06-de7a-43da-8a99-34ec8099c57a"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3474), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3474), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3474) },
                    { new Guid("4b4218b4-9013-4391-902d-4e7dc957c7ab"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3670), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3670), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3670) },
                    { new Guid("4c3c3c4b-5383-4536-adcb-f46d9bd9cd7f"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3724), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3724), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3724) },
                    { new Guid("4cc39deb-b167-46ac-b8c8-2cd010c6499e"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3584), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3584), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3584) },
                    { new Guid("4ccd6b56-b033-4b43-9100-ba327fe49fa9"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3667), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3667), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3667) },
                    { new Guid("51074df1-2f72-4ecc-88e0-bcf10a141ed4"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3588), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3588), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3588) },
                    { new Guid("51c33794-32d4-4873-aca7-1371afe4ebdb"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3458), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3458), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3458) },
                    { new Guid("53b9ca51-2d75-45ff-92ee-209dc7b019dc"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3596), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3596), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3596) },
                    { new Guid("54431f19-56e3-4b63-86b1-40565ca9dd83"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3768), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3768), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3768) },
                    { new Guid("5bb8e89d-2720-4492-9d39-ad5260365e2a"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3530), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3530), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3530) },
                    { new Guid("64dfe49f-4fee-4e5c-8b83-aaea5fcc6984"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3546), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3546), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3546) },
                    { new Guid("65af39b5-4619-4de4-b4f3-3315ff44c8d6"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3631), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3631), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3631) },
                    { new Guid("6907d9ce-12a3-40d3-80df-937c11807301"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3651), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3651), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3651) },
                    { new Guid("69f5c951-f642-4490-bfe0-b9506730df90"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3604), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3604), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3604) },
                    { new Guid("6a8c82dd-3a20-405e-8ef8-54539321cc0a"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3701), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3701), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3701) },
                    { new Guid("6b81f0e7-10be-415c-a126-76a2c0817c45"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3491), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3491), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3491) },
                    { new Guid("6e99d84f-84b7-41c7-8c58-29f200f9c42c"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3802), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3802), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3802) },
                    { new Guid("73a054d0-c8ab-4f4f-b5b6-5c7d30053e1c"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3640), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3640), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3640) },
                    { new Guid("7c21736b-0115-463f-a4d8-80c66b974377"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3721), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3721), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3721) },
                    { new Guid("7e786c87-6e43-401d-97aa-5106ef16f087"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3462), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3462), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3462) },
                    { new Guid("824a7ab8-f0b9-42c4-8633-d765de9cf55d"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3479), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3479), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3479) },
                    { new Guid("84c9a2c7-94ed-4731-8092-d492636b2655"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3648), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3648), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3648) },
                    { new Guid("86c4b294-1f78-4ccb-946a-aea26b737c7b"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3654), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3654), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3654) },
                    { new Guid("8754b830-c3f6-472f-9435-2f8f52d5a5c5"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3443), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3443), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3443) },
                    { new Guid("8d1e7904-4151-4316-91f8-39ecbffbb437"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3498), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3498), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3498) },
                    { new Guid("901999de-4ec7-4e15-a3f6-fe651bbc6238"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3794), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3794), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3794) },
                    { new Guid("91e58225-e061-49e4-8a1f-a761ce6ec601"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3682), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3682), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3682) },
                    { new Guid("95d30bab-b1bc-4b19-b57e-9a4405ab6abd"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3780), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3780), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3780) },
                    { new Guid("9e552fd6-dd7a-4eba-b9a4-2fd327f75a1e"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3599), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3599), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3599) },
                    { new Guid("9eb7255d-0a72-4ace-a8d0-da4fb7d455c9"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3620), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3620), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3620) },
                    { new Guid("9f19313b-4a83-4be5-9845-4bda3c746a3b"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3788), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3788), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3788) },
                    { new Guid("a07257c8-af60-440c-8966-0cfabb532e0b"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3495), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3495), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3495) },
                    { new Guid("a2c0081b-8a6c-4dc8-b10f-b527197afb2e"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3612), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3612), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3612) },
                    { new Guid("a41ff6b9-552f-4375-8d32-dc6f3886954a"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3810), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3810), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3810) },
                    { new Guid("a6c19fe7-0163-4857-9239-0f3c15c39663"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3693), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3693), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3693) },
                    { new Guid("aca3547d-a06b-41e0-b795-61ae9affeb68"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3482), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3482), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3482) },
                    { new Guid("adf788c2-b80e-41a1-9614-6951b4e0edf0"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3805), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3805), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3805) },
                    { new Guid("ae9cb741-3ebb-4b79-b82c-f97a40143a3a"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3527), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3527), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3527) },
                    { new Guid("afe67f72-5915-405d-9394-bad3bf358799"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3523), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3523), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3523) },
                    { new Guid("bafd486b-9c2f-45dc-849f-75e3dbef5c36"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3538), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3538), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3538) },
                    { new Guid("bef099f8-bfcf-4099-b7b9-a6723242d9f8"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3608), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3608), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3608) },
                    { new Guid("c1402d0a-d48a-4898-bee5-3c5b219de8b3"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3709), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3709), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3709) },
                    { new Guid("c5e6a883-30b2-4d43-bfcf-addddd66ca10"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3543), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3543), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 29, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3543) },
                    { new Guid("c78995b2-307f-4e64-b9f1-d163da953307"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3799), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3799), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3799) },
                    { new Guid("c8b132da-a123-4f77-9712-606ca1a8e4c4"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3755), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3755), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3755) },
                    { new Guid("cb64fd64-2bfe-41d7-b827-6a7e8a50cf23"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3465), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3465), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3465) },
                    { new Guid("d2ef02a8-b61a-4efa-8f0e-3d47f361aced"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3783), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3783), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3783) },
                    { new Guid("d6f5034d-d841-4c32-9b71-eec327c25edd"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3471), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3471), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3471) },
                    { new Guid("d907a77a-6ea3-4253-b43e-60c0a220d3d8"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3771), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3771), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3771) },
                    { new Guid("ddcd446d-f5f6-4294-8447-9077acd744ec"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3506), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3506), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 30, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3506) },
                    { new Guid("ddd04612-cee7-48f7-834f-1ff74c9b848f"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3617), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3617), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 28, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3617) },
                    { new Guid("e576363d-9e15-4126-8195-0e4f04b2f7b5"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3759), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3759), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 25, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3759) },
                    { new Guid("e5d82a83-b0cd-4d00-82fd-d92e550f577f"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3452), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3452), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3452) },
                    { new Guid("e9eaaad1-d32e-469e-a59b-510ea45aafc8"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3814), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3814), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 24, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3814) },
                    { new Guid("f51906b7-06fd-454b-92e5-21a827142d1b"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3679), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3679), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3679) },
                    { new Guid("f64bdbe3-c7ac-4f57-bea7-17b441a176c5"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3659), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3659), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3659) },
                    { new Guid("f7dd6454-e997-445e-a8e1-1ea2af64eb3b"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3690), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3690), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3690) },
                    { new Guid("f810dac7-f378-4ced-96fe-482b529043f8"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3662), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3662), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 27, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3662) },
                    { new Guid("f9d20454-b7e5-4c95-8c44-bac83af5e915"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3712), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3712), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 26, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3712) },
                    { new Guid("fc168ad2-317a-4986-ae21-62364304d2f9"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3486), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3486), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 10, 1, 20, 23, 0, 66, DateTimeKind.Local).AddTicks(3486) }
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
                name: "IX_ExpenseReports_RestaurantId",
                table: "ExpenseReports",
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
                name: "ExpenseReports");

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
