using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestroFlowAPI.Migrations.RestroFlowDb
{
    /// <inheritdoc />
    public partial class InitialSeedCommit : Migration
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
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
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
                    BudgetCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budgets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Budgets_Restaurants_RestaurantId",
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
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExpenseType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpenseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RestaurantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_Restaurants_RestaurantId",
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
                name: "RestaurantMenus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantMenus_Restaurants_RestaurantId",
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
                name: "SaleReports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumberOfTransactions = table.Column<int>(type: "int", nullable: false),
                    TotalSalesRevenue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrossProfit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetProfit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BestSellingItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BestSellingItemQuantity = table.Column<int>(type: "int", nullable: false),
                    WorstSellingItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorstSellingItemQuantity = table.Column<int>(type: "int", nullable: false),
                    SalesByCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalesByPaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RestaurantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleReports_Restaurants_RestaurantId",
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
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SaleDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RestaurantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RestaurantMenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PaymentMethodId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sales_RestaurantMenus_RestaurantMenuId",
                        column: x => x.RestaurantMenuId,
                        principalTable: "RestaurantMenus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sales_Restaurants_RestaurantId",
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
                    { new Guid("7d3fa15f-2caa-42e4-8390-66a0cb81541d"), new Guid("f2ba15e2-f1d3-43d1-bb84-6767253ebbe2") },
                    { new Guid("7f456709-4f7e-4ec6-94d7-4f74744883d2"), new Guid("9125374f-e121-40f2-b42f-089529dd5fbd") },
                    { new Guid("aa69fea5-f0f0-4fcf-a845-70333065d74d"), new Guid("21804e79-b2bb-4a6e-9418-3cab51e579ac") },
                    { new Guid("bb30dbfc-2ffd-48f0-a8f8-916fea5b4cdd"), new Guid("36c8f410-61d4-49fb-beb0-ff35e319614e") }
                });

            migrationBuilder.InsertData(
                table: "ItemLocations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("bfab0743-950f-4eeb-9809-430d2fd307e6"), "Back of House Stock Lists" },
                    { new Guid("f0ec9038-432a-4353-8456-b95dacfafc94"), "Front of House Stock Lists" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "CreatedAt", "PaymentName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(1176), "EFTPOS", new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(1178) },
                    { new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(1169), "DoorDash", new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(1173) },
                    { new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(816), "Uber Eats", new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(954) }
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
                    { new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "88 Kangaroo Court", " Brisbane", " JamesCooper@FFI.com", "James Cooper", "08 9314 7890", new DateTime(2024, 9, 18, 3, 49, 4, 616, DateTimeKind.Local).AddTicks(6387), "Fresh Food Industries", "VIC", new DateTime(2024, 9, 18, 3, 49, 4, 616, DateTimeKind.Local).AddTicks(6389) },
                    { new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "23 Sunset Avenue", "Fremantle", "OliviaMiller@GFIFood.com", "Olivia Miller", "03 6234 9087", new DateTime(2024, 9, 18, 3, 49, 4, 616, DateTimeKind.Local).AddTicks(6392), "GFI Foods", "VIC", new DateTime(2024, 9, 18, 3, 49, 4, 616, DateTimeKind.Local).AddTicks(6394) },
                    { new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "45 Maple Street", "South Yarra", "SarahJohnso@CFS.com", "Sarah Johnso", "07 3345 6721", new DateTime(2024, 9, 18, 3, 49, 4, 616, DateTimeKind.Local).AddTicks(5836), "Complete Food Services", "VIC", new DateTime(2024, 9, 18, 3, 49, 4, 616, DateTimeKind.Local).AddTicks(6378) }
                });

            migrationBuilder.InsertData(
                table: "Budgets",
                columns: new[] { "Id", "BudgetAmount", "BudgetCategory", "BudgetEndDate", "BudgetStartDate", "CreatedAt", "Description", "RestaurantId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("169e29cd-b12d-4d17-83e3-40aab1db2498"), 1000m, "Labour", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6726), new DateTime(2024, 9, 11, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6725), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b6c34ad9-a800-4b75-b5f1-7cc171bcde0f"), 400m, "Others", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6730), new DateTime(2024, 9, 11, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6729), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bda79493-9ffd-438a-8bab-6efbe40dff9a"), 2000m, "Supplies", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6721), new DateTime(2024, 9, 11, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6718), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Amount", "ExpenseDate", "ExpenseType", "RestaurantId" },
                values: new object[,]
                {
                    { new Guid("112a1820-417a-4b6e-a9e9-8edb69a41f47"), 80m, new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6355), "Internet", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("1e965f32-6969-4e5b-86d7-ec7cde25e875"), 120m, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6331), "Internet", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("212d083a-1a22-46ac-bc7a-ab3587fce74b"), 1500m, new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6362), "Rent", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("2d66e904-4b7f-46c5-97b1-91c2a778ca32"), 80m, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6325), "Labour", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("48b3edb1-1978-4abf-b265-809b9edc5e74"), 120m, new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6352), "Electrictity", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("5e85c285-61d6-40b3-b31f-809155df63ce"), 250m, new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6375), "Internet", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("62d7d9ee-a075-4de4-83a1-48125e78714a"), 80m, new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6359), "Water", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("86aaa890-4aec-4d8e-82b5-48747ea8eebf"), 250m, new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6365), "Supplies", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("878d4fd8-eef3-44e9-bfee-52278a8468bc"), 100m, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6337), "Water", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("a1e2e62f-9ee4-48e3-a0ae-47e1d4dad1aa"), 100m, new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6369), "Labour", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("ab917a8a-cdbc-4b1b-9593-e4d4753d905c"), 1500m, new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6340), "Rent", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("b9b1116f-2c10-4a26-99b4-b36985f638a1"), 250m, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6319), "Supplies", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("c3a531d1-9a8c-4902-84f2-73361c1943cd"), 250m, new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6348), "Labour", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("ce962f64-63f4-42b6-ae06-3fb4ec81ff93"), 120m, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6328), "Electrictity", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("dcb185f3-0004-4047-8295-c5f6ca69f65d"), 80m, new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6381), "Water", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("e72b9c55-4334-4dfd-a14c-ee84ff387494"), 120m, new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6372), "Electrictity", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("e9065bea-538d-4368-abe9-9971781c42dc"), 80m, new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6343), "Supplies", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("ecc90f1d-580e-48e8-b8c2-c510cc4b7db9"), 1500m, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6312), "Rent", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") }
                });

            migrationBuilder.InsertData(
                table: "RestaurantItems",
                columns: new[] { "Id", "CreatedAt", "Description", "ItemLocationId", "Name", "RestaurantId", "SupplierId", "Unit", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(283), null, new Guid("bfab0743-950f-4eeb-9809-430d2fd307e6"), "Chicken wings", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(285) },
                    { new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(271), null, new Guid("bfab0743-950f-4eeb-9809-430d2fd307e6"), "Boneless chicken", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "box", new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(278) },
                    { new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(323), null, new Guid("f0ec9038-432a-4353-8456-b95dacfafc94"), "Spicy sauce", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(324) },
                    { new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(330), null, new Guid("f0ec9038-432a-4353-8456-b95dacfafc94"), "Sweet Chiilies", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(331) },
                    { new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(297), null, new Guid("bfab0743-950f-4eeb-9809-430d2fd307e6"), "Marinated beef", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion", new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(299) },
                    { new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(335), null, new Guid("f0ec9038-432a-4353-8456-b95dacfafc94"), "Wedges", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(336) },
                    { new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(312), null, new Guid("f0ec9038-432a-4353-8456-b95dacfafc94"), "Chicken powder", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(313) },
                    { new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new DateTime(2024, 9, 18, 3, 49, 4, 616, DateTimeKind.Local).AddTicks(9365), null, new Guid("bfab0743-950f-4eeb-9809-430d2fd307e6"), "Whole chicken", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "Portion", new DateTime(2024, 9, 18, 3, 49, 4, 616, DateTimeKind.Local).AddTicks(9529) },
                    { new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(289), null, new Guid("bfab0743-950f-4eeb-9809-430d2fd307e6"), "Chicken Steak", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(290) },
                    { new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(317), null, new Guid("f0ec9038-432a-4353-8456-b95dacfafc94"), "Soy garlic", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 617, DateTimeKind.Local).AddTicks(319) }
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

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Rating", "RestaurantId", "ReviewContent", "ReviewDate", "ReviewSource" },
                values: new object[,]
                {
                    { new Guid("1a6fc648-a7db-4a82-ac7b-c1de2ac6f3a1"), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6798), "Instagram" },
                    { new Guid("2bb1a70b-91ae-4c4a-82d0-0c0073437c7f"), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6793), "Google" },
                    { new Guid("2d7589b4-a624-44a2-b3e7-631438098ca3"), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6784), "Google" },
                    { new Guid("5971d1f0-a08b-4e71-8eec-eca67771ad0f"), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6789), "Google" },
                    { new Guid("5c0d6f65-3b3e-4a4b-92ca-525dc3c6d35a"), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6808), "Others" },
                    { new Guid("95feec59-038d-427e-8f29-98c6ebca987c"), 2f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6823), "Others" },
                    { new Guid("9983c2fb-8414-490b-9bbc-3493555ca7c2"), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6817), "Facebook" },
                    { new Guid("9a4fd87e-d719-4b69-9e84-2945f01cb340"), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6761), "Others" },
                    { new Guid("d1c0353a-d61e-49a7-a751-cb4941e3413f"), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6805), "Instagram" },
                    { new Guid("ed0d1f79-8f7d-4ed1-b3b3-5c5bcc3004fa"), 2f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6813), "Facebook" }
                });

            migrationBuilder.InsertData(
                table: "SupplierItems",
                columns: new[] { "Id", "CreateAt", "Description", "Name", "Price", "SupplierId", "Unit", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("02995976-7ce0-4339-a172-d8f00a55bf87"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7444), null, "Tomato Relish", 10m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bottle", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7445) },
                    { new Guid("062bb050-432b-4708-9e5b-36b0825a5e15"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7345), null, "Mayonnaise", 50m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bucket", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7346) },
                    { new Guid("09322808-ce78-4084-b68b-5af4073bfd47"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7355), null, "Sour cream", 50m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "tub", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7357) },
                    { new Guid("11211530-e4c3-4e9f-936b-6b622caeffed"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7256), null, "Chips", 13.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7257) },
                    { new Guid("171a2304-2ed0-4317-a15d-4a2a680e8555"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7438), null, "Whole gain mustard", 20.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "tub", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7439) },
                    { new Guid("1c238dd0-f036-4d09-85fc-6a4c8510a057"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7102), null, "Whole chicken", 19.9m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "pack", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7105) },
                    { new Guid("1f9e4a02-7f7c-4483-b688-f7fa937c25c3"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7287), null, "Corn ribs", 34m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "pack", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7288) },
                    { new Guid("23bbf7be-c791-44d3-9655-37197206aa80"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7249), null, "Drumstick", 22m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7251) },
                    { new Guid("25f3405c-09cd-4137-b230-82aae760d1fe"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7464), null, "Hotteok", 17.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "pack", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7465) },
                    { new Guid("26678aac-aa6f-4d71-baff-bf7e38766ca2"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7113), null, "Chicken powder", 34m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7115) },
                    { new Guid("330e939a-d23d-4b64-b2cf-5704c8934d12"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7217), null, "Corn kernel", 11m, new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7218) },
                    { new Guid("331ef95a-a260-4b56-b8ba-ae0e9d2f3216"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7122), null, "Coleslaw", 19.9m, new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7123) },
                    { new Guid("35d3154c-1ac4-49d2-8671-97ee162e32b8"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7334), null, "Milk", 22m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "carton", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7335) },
                    { new Guid("421ab053-48d1-475f-b745-4bd10d7bd7aa"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7375), null, "Slider bun", 10m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7377) },
                    { new Guid("43ee5333-d2e2-477f-b4d7-5a1178803eca"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7329), null, "Eggs", 34m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "dozen", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7330) },
                    { new Guid("45f6f1e3-1c97-4292-8e15-1bd004e1c0f2"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7470), null, "K-donut", 30.2m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "pack", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7471) },
                    { new Guid("4d1e10b1-7114-49dd-a18f-4c86376d21c6"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7152), null, "Rice cake", 13.5m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7153) },
                    { new Guid("4fc17b13-06de-4375-81c6-09b5046c88d2"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7240), null, "Dried garlic", 30.2m, new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "container", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7241) },
                    { new Guid("5233f9ab-3281-46e2-83f9-aa9f5918933b"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7397), null, "Crushed garlic", 17.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bucket", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7398) },
                    { new Guid("54f68440-d99b-44c1-996e-5c0736ac9ece"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7245), null, "Dumpling", 30.9m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7246) },
                    { new Guid("60e7d3b7-b240-4db0-8a8f-f82938cc76a9"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7276), null, "Seasame oil", 19.9m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "can", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7277) },
                    { new Guid("6350e4df-1e37-4375-b18d-1a84acda5ed9"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7266), null, "Skewers", 19.9m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7268) },
                    { new Guid("6564810a-dd0b-4e78-9535-978d1c560985"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7128), null, "Instant noodle", 21m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "pack", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7130) },
                    { new Guid("68c1aa55-6a5d-45cc-b6da-15be280e63ae"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7366), null, "Mozzarella cheese", 13.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7367) },
                    { new Guid("6a579384-f133-4028-8d57-1b36987e573d"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7206), null, "Chicken steak", 34m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7207) },
                    { new Guid("6c279510-c570-4426-ae19-65efa91587f1"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7156), null, "Chicken wings", 34m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7158) },
                    { new Guid("6cdc3463-0488-4350-aa74-13307ab8250d"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7421), null, "Salted butter", 11m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "pack", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7423) },
                    { new Guid("73238e49-1a02-4652-b4b3-48ea5dfb7489"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7302), null, "Mustard", 17.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7303) },
                    { new Guid("7926f817-1661-4387-b109-47bcaf0c3f8a"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7228), null, "Marinated beef", 19.9m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7229) },
                    { new Guid("7a8441cd-9680-43e8-bde8-995348ef7c5a"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7381), null, "Red spicy mayo", 30.2m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7383) },
                    { new Guid("7b121047-581a-47b4-99a1-d6731264772c"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7271), null, "Shoestring chips", 13.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7273) },
                    { new Guid("7e169ff7-a826-4e16-b88e-feac846a46ed"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7133), null, "Boneless Chicken", 22m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "box", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7134) },
                    { new Guid("82b777f0-a1f5-402c-84a4-a86c2f53ab75"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7145), null, "White radish", 50m, new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "container", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7147) },
                    { new Guid("893eac20-e06f-4342-8fc5-03d894445474"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7189), null, "Spicy sauce", 34m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7191) },
                    { new Guid("8ee22a13-126d-428e-aef3-2375964224f1"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7433), null, "Potato flake", 50m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7434) },
                    { new Guid("946397d0-7c0f-47a9-b770-ef4b8941c13d"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7459), null, "Japchae mandu", 21m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "pack", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7461) },
                    { new Guid("9c38b888-2705-4d3c-a14b-951b8d001ff7"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7313), null, "Carrot rings", 20.5m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "pack", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7314) },
                    { new Guid("9c6e7007-19fd-451d-8eff-df015e2784ce"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7223), null, "Pancake mix", 13.5m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7225) },
                    { new Guid("a059496c-c33d-4dde-9a64-2babab97566b"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7351), null, "Fish cake", 50m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7352) },
                    { new Guid("a8e9a601-15c1-4547-a1df-27d3df5b5602"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7428), null, "Cheese sauce", 10m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7430) },
                    { new Guid("ad645a27-6d41-4662-b57e-b0cf6bcb8a2c"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7455), null, "Prawn burger", 30.9m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "pack", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7456) },
                    { new Guid("adde144b-66eb-41fd-8661-3a9cc7180723"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7448), null, "Prawn mandu", 17.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "pack", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7450) },
                    { new Guid("b34f882e-85b9-42c0-8f60-437222e140d3"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7392), null, "Tteokbokki sauce", 11m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7394) },
                    { new Guid("bbbbea70-55f1-423d-9c62-ece78391603f"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7260), null, "Corn syrup", 11m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "gallon", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7262) },
                    { new Guid("c0099247-cc9d-423d-a255-f36a1c077849"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7282), null, "Boiled gochujang", 11m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7283) },
                    { new Guid("c410fda5-443b-4353-b02f-197202acc0f8"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7340), null, "Potato noodle", 22m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "box", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7341) },
                    { new Guid("cefbe9c9-681e-4eec-96d9-69242528093f"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7140), null, "Soy garlic", 34m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7142) },
                    { new Guid("d09c73db-3272-4a1a-85f6-d3e5110f8390"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7325), null, "Thai sweet chilli", 19.9m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "gallon", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7326) },
                    { new Guid("d2effc3e-53c5-40df-9974-c7b49fc65b20"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7233), null, "Wedges", 10m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7235) },
                    { new Guid("e09d4dbd-058b-4947-a76c-cb9fb8167bf6"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7386), null, "Gochujang sauce", 20.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7387) },
                    { new Guid("e115ada3-1337-4c6a-8a47-9113c1ed4ebf"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7291), null, "Beef dashida", 19.9m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7293) },
                    { new Guid("e5aa79d0-9664-498a-8090-38f34d40f220"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7371), null, "Burger bun", 17.5m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7372) },
                    { new Guid("eaab45c0-c571-40f3-8739-664343b87d12"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7297), null, "Boxing wings", 50m, new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7299) },
                    { new Guid("ee3a0714-4f42-4364-851f-84ac38782138"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7201), null, "Frying mix", 50m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7203) },
                    { new Guid("f070607b-e18b-4a6c-a180-d5e440007e21"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7360), null, "Soy sauce", 30.2m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "jerrycan", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7361) },
                    { new Guid("f664585e-97dc-40b9-ab9f-0b11a15c0a2b"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7308), null, "Kimchi", 30.2m, new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "container", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7309) },
                    { new Guid("f7437323-98c8-4b83-9e86-ee56e4a913a3"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7212), null, "Sweet chillies", 10m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7214) },
                    { new Guid("f8d6c231-5013-4820-aad7-0136effac76c"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7196), null, "Mix salad", 34m, new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "box", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7198) },
                    { new Guid("ff7f86f0-89a4-44ab-b2f7-7ea17f95815b"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7318), null, "Ketchup", 30.2m, new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "gallon", new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7320) }
                });

            migrationBuilder.InsertData(
                table: "InventoryAlerts",
                columns: new[] { "Id", "CreatedAt", "RestaurantItemId", "Threshold", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0ca25975-4662-4e38-bdf0-4af0dfbf76c1"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6651), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), 20f, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6652) },
                    { new Guid("102c9565-dc77-4673-9794-792cb3864777"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6624), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), 9f, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6626) },
                    { new Guid("17cf087e-62f4-47dc-a395-8c1afcbf2f1c"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6655), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), 25f, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6656) },
                    { new Guid("1c0b4e4c-34c3-4a7f-84d8-eea3736b5b68"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6615), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), 5f, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6618) },
                    { new Guid("42e829da-921c-48c9-a9b9-84e27712687d"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6639), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), 8f, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6641) },
                    { new Guid("64d8ab5b-823d-4760-9d2f-fe21d5fb8299"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6645), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), 5f, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6646) },
                    { new Guid("ac137e6a-3704-4b9b-b4e0-98a918bb419f"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6633), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), 8f, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6635) },
                    { new Guid("bf9e573d-2289-4dbd-8e55-07fa36e239a4"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6666), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), 9f, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6667) },
                    { new Guid("cb1f2818-3135-4067-aa91-bc0d7d00cb1e"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6629), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), 5f, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6630) },
                    { new Guid("e25e8668-c4d5-4a5f-9a23-d7c3865d57ea"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6659), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), 20f, new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6660) }
                });

            migrationBuilder.InsertData(
                table: "RestaurantInventories",
                columns: new[] { "Id", "LastUdpated", "Quantity", "RestaurantId", "RestaurantItemId", "SupplierId", "Unit" },
                values: new object[,]
                {
                    { new Guid("000f8dcd-9fda-4897-966f-64175b015fb0"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6565), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("03da3f33-b3f4-40e0-a095-a125b11fecf9"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6442), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "container" },
                    { new Guid("0c65ebef-2ce5-45b0-a0cb-bd84514f7ee3"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6569), 9f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("1ed51c1d-de18-4346-8fda-694d9daf0cd6"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6455), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("22c1c9c0-9db4-4337-9456-548a042ea285"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6476), 9f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "box" },
                    { new Guid("2bf69225-7dd1-422b-808d-218b26aec26c"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6429), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "Portion" },
                    { new Guid("4b02782b-21d5-48df-92d4-3b612f4c3696"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6526), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("4b8382c7-bd90-4866-adfd-6d2ac077874e"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6505), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "container" },
                    { new Guid("55c256e8-c5ce-41d6-99c4-a327c41dac57"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6460), 22f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("5830d634-bddb-4fa2-8ca1-b1937937a05d"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6434), 9f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "box" },
                    { new Guid("61cd757d-158f-4695-9368-cfb6a0ce8699"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6546), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "container" },
                    { new Guid("76a7db50-a68b-41d8-ad4d-3fbf95f79ab4"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6517), 6f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("8792a8c2-2122-4e31-98f5-da2a744d7840"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6552), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("98b193d1-5f82-4434-afe1-905e54879358"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6535), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "Portion" },
                    { new Guid("993ccd00-82d3-4804-b4f2-48d240cd8f6e"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6439), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "container" },
                    { new Guid("9bf90583-cf9d-4652-bf6a-fc17b7ca0872"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6481), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container" },
                    { new Guid("a10e49e0-8efa-4d45-a6b6-663a73bcb5d0"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6557), 22f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("bb0a98ba-73f2-4cf7-81e2-76a9521a1605"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6447), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion" },
                    { new Guid("c41ee45d-b0d4-4378-84ec-1b79f0622475"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6530), 6f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("c50da2c6-6661-41d6-ab5a-86cb5d08141b"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6514), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("c90d431e-2302-4954-a167-480ce2e169ae"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6561), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("c94cd4d5-290f-4f8c-83e1-22fe03f682f2"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6473), 9f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "Portion" },
                    { new Guid("d0556b26-37f9-49b9-83cd-c13bec81e89d"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6468), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("e3625a38-c9c2-43b5-be3b-ea67de971a3a"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6538), 22f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "box" },
                    { new Guid("e6aa81e7-9291-4b79-8b2c-c8b66ad36634"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6549), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion" },
                    { new Guid("e972e228-0827-4c7d-bf0e-be17b396a467"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6541), 9f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "container" },
                    { new Guid("ecd139dc-2192-4de3-ab55-d26fc2ea3ff2"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6509), 22f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "portion" },
                    { new Guid("f44c6f88-e1e4-4b75-9cfd-8dfb2df7284c"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6452), 6f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("f53a203b-54a4-4622-b813-147e734087af"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6463), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("f6e78109-32a1-4945-8a1d-13d7691ce410"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6521), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "PaymentMethodId", "Quantity", "RestaurantId", "RestaurantMenuId", "SaleDate", "TotalAmount" },
                values: new object[,]
                {
                    { new Guid("03077636-bfb8-4660-99f4-df412b0fce93"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 20, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("bab92f8b-1fd6-4fbb-9c66-777c49280d54"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6020), 310.0m },
                    { new Guid("03092594-4925-49d0-9d76-2f036ee0b135"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 18, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("07a67762-a063-46db-94d1-080237b187a5"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6016), 288m },
                    { new Guid("033dceac-4459-4cb7-8df2-2dbbdf2fddb5"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 20, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("d5d66b38-5140-485b-8575-f83d5fae6a5f"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6180), 320m },
                    { new Guid("0dfa49d0-d81f-4cf3-abe5-224d8b1fc2d3"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("fc693bcd-807b-4506-a8fd-dc3e31905a81"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6196), 14.5m },
                    { new Guid("181ef4e5-8218-4aeb-95c5-2eb9aac6e130"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("19924c8f-32e0-4c3d-b425-995ed0ddca5a"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(5981), 296.0m },
                    { new Guid("1de17cc8-a7bb-4062-ae76-11320067c03f"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("9ca19c31-2e04-42e7-8cad-6e61bd177eaf"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6046), 84m },
                    { new Guid("1f3586d3-b4f0-4edc-b8e0-c7849ebe7ded"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("19924c8f-32e0-4c3d-b425-995ed0ddca5a"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6176), 296.0m },
                    { new Guid("23e1f09f-1ce2-4e2a-b2ed-8edae248bb02"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("bab92f8b-1fd6-4fbb-9c66-777c49280d54"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6127), 31.0m },
                    { new Guid("29366746-ff07-400c-b5bd-a5c1a40c1bcf"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 11, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("d5d66b38-5140-485b-8575-f83d5fae6a5f"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6074), 176m },
                    { new Guid("2b44b1c7-266f-49c7-8270-3d3570673848"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("9ca19c31-2e04-42e7-8cad-6e61bd177eaf"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6153), 84m },
                    { new Guid("2c77f2eb-1155-42bd-9cd7-a25572a39771"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f6c1d21b-b9dd-452f-8e14-364f530bf7b8"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6036), 16.5m },
                    { new Guid("4998bc4b-46a6-4bb2-80d8-a94f71bd14d8"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 12, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("d5d66b38-5140-485b-8575-f83d5fae6a5f"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(5986), 192m },
                    { new Guid("4cefbfdf-6238-477a-8fd5-ba0c985b775f"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 15, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("4d165d8f-fbcf-4144-a318-374e7f08cb57"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6054), 600m },
                    { new Guid("51bbf150-5020-4ce2-9b18-a4d2d0272cde"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("29585767-ced3-46a6-8f1f-06455c4b1172"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6010), 216.0m },
                    { new Guid("57578304-4e0a-4aa3-a493-dfd14893fc79"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 20, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("29585767-ced3-46a6-8f1f-06455c4b1172"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6117), 270.0m },
                    { new Guid("5ad22793-1e75-49d6-b94a-25a8db0583e2"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 10, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("bab92f8b-1fd6-4fbb-9c66-777c49280d54"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6212), 155.0m },
                    { new Guid("5fc6fb95-c1cb-47ed-abbb-76313fe2bf7a"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 12, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("07a67762-a063-46db-94d1-080237b187a5"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6208), 192m },
                    { new Guid("616dec7c-ec41-479a-916f-869dcb34d390"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 20, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("fc693bcd-807b-4506-a8fd-dc3e31905a81"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6003), 290.0m },
                    { new Guid("62ffa85f-60f2-4c1a-aa9a-4acde358e76f"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 10, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("d02988c8-bd91-400d-8593-403c285c6dfb"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6222), 280m },
                    { new Guid("6626f290-7cfb-4fe3-87ce-0fdcca70cedd"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 10, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("d02988c8-bd91-400d-8593-403c285c6dfb"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6030), 280m },
                    { new Guid("667cb02d-383b-45e2-87c8-d606bc64fd8d"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 18, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("9ca19c31-2e04-42e7-8cad-6e61bd177eaf"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(5909), 756m },
                    { new Guid("6a1f3d70-8118-4da7-bd97-7ead5fbbda20"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("75734df5-e59e-4d9e-a224-ed8e4ae67fdd"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6218), 20m },
                    { new Guid("6be29f64-cca9-4d63-ad1e-0f664f096e26"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 18, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("1d74b052-3b59-465f-add2-d91f96b8961a"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6060), 378m },
                    { new Guid("72350811-b7de-4023-b3e2-9fb58c6f1aa1"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f6c1d21b-b9dd-452f-8e14-364f530bf7b8"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6143), 16.5m },
                    { new Guid("75733e58-38e9-4d85-a70c-9789c9f29f2b"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("dd636f75-f510-47eb-bfc8-cf2613defdba"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(5993), 232.0m },
                    { new Guid("81ef0af4-7e5e-4212-abfe-5e63c9987551"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("29585767-ced3-46a6-8f1f-06455c4b1172"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6202), 216.0m },
                    { new Guid("875fae7d-032c-4901-a1bf-aed4dd1cfdaf"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 18, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("6dac4780-fbf3-41f4-8971-b7abdef83a86"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(5999), 124.2m },
                    { new Guid("8a77a7b2-c8c6-4a70-9010-7e438a1049a2"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 11, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("fc693bcd-807b-4506-a8fd-dc3e31905a81"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6110), 159.5m },
                    { new Guid("8b674b31-5522-4ec3-b396-622637c43fa2"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 18, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("6dac4780-fbf3-41f4-8971-b7abdef83a86"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6085), 124.2m },
                    { new Guid("8f4ca694-7bf5-4f7e-a294-0b72deb9f1c4"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 10, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("4d165d8f-fbcf-4144-a318-374e7f08cb57"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(5963), 400m },
                    { new Guid("98843a9a-b39b-4d64-beda-05afe7adbe37"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 12, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("75734df5-e59e-4d9e-a224-ed8e4ae67fdd"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6133), 120m },
                    { new Guid("a55190d7-e6b3-4f4f-9499-f647b004d4eb"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 12, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("19924c8f-32e0-4c3d-b425-995ed0ddca5a"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6070), 222.0m },
                    { new Guid("a69b2a96-5135-4f9a-8f07-030a56b74bcb"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 18, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("45859bd4-b0bd-4491-8b1b-7c33a940df8a"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(5975), 306m },
                    { new Guid("b1b3b35e-e7e1-43f4-9b2e-cc757f1c2bf2"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("dd636f75-f510-47eb-bfc8-cf2613defdba"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6186), 232.0m },
                    { new Guid("b1f7077e-0de3-4ba2-90cf-2c02a99c3db6"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 10, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("75734df5-e59e-4d9e-a224-ed8e4ae67fdd"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6026), 100m },
                    { new Guid("b94bd897-a11d-4554-a4ae-0fb623533cf0"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 18, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("6dac4780-fbf3-41f4-8971-b7abdef83a86"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6192), 124.2m },
                    { new Guid("be4ac319-25b7-4a9a-8ddc-b69ba9c4a87a"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("6e4aaccc-3c0d-4d91-a8e0-10e1a70a24f2"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6233), 30m },
                    { new Guid("cfa619ae-ae81-4d3e-9a17-2eb1b0a98d6d"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("07a67762-a063-46db-94d1-080237b187a5"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6123), 256m },
                    { new Guid("d230d302-256f-481c-b993-e7e8b3516c31"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("45859bd4-b0bd-4491-8b1b-7c33a940df8a"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6170), 272m },
                    { new Guid("d2aae4e9-e450-4477-8d63-d58d3eba236f"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("6e4aaccc-3c0d-4d91-a8e0-10e1a70a24f2"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6042), 30m },
                    { new Guid("de4d9706-e31a-424e-827d-ba03ad9a59ab"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 10, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("1d74b052-3b59-465f-add2-d91f96b8961a"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(5971), 210m },
                    { new Guid("dff86284-fffc-4fdc-903e-c179227d4359"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("d02988c8-bd91-400d-8593-403c285c6dfb"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6137), 56m },
                    { new Guid("e0ce8c13-a47c-4f2f-8e56-3a04352dc180"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 10, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f6c1d21b-b9dd-452f-8e14-364f530bf7b8"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6228), 165.0m },
                    { new Guid("e1bca2b4-1d91-437a-a0ea-3440daada393"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("1d74b052-3b59-465f-add2-d91f96b8961a"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6166), 336m },
                    { new Guid("e3a6b523-a1a1-4abb-889c-0465fc548672"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 10, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("dd636f75-f510-47eb-bfc8-cf2613defdba"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6079), 145.0m },
                    { new Guid("ee648794-2461-4111-b91f-0e1b56b132a9"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 18, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("6e4aaccc-3c0d-4d91-a8e0-10e1a70a24f2"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6149), 270m },
                    { new Guid("f0deca0b-d8c1-446e-80e7-0c0973c027a0"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("4d165d8f-fbcf-4144-a318-374e7f08cb57"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6160), 80m },
                    { new Guid("fa299f8f-2200-4679-b94b-f80d85386157"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 15, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("45859bd4-b0bd-4491-8b1b-7c33a940df8a"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6064), 255m }
                });

            migrationBuilder.InsertData(
                table: "StockOrders",
                columns: new[] { "Id", "CreatedAt", "OrderDate", "Quantity", "RestaurantId", "RestaurantItemId", "SupplierId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0103303c-7d40-44f7-b1b9-aa3cc0d7655d"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7016), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7016), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7016) },
                    { new Guid("07b11419-54fa-4def-b0cb-4bb3114d4aa2"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6910), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6910), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6910) },
                    { new Guid("1da6dab8-9b5b-46dc-b4eb-c1683571e7e5"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6941), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6941), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6941) },
                    { new Guid("1e3df16d-4d90-48d8-b010-8bb41c1827f9"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6876), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6876), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6876) },
                    { new Guid("22837912-7bfe-4641-b3d0-5ddd3bb792ee"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7022), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7022), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7022) },
                    { new Guid("22def6c0-4270-4606-aa51-39685a24783f"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6898), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6898), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6898) },
                    { new Guid("23d4eadd-f4f8-4199-8f20-1a1453be6efc"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6933), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6933), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6933) },
                    { new Guid("242c2e60-b175-4dcc-915d-de03c1f3cf2b"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6938), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6938), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6938) },
                    { new Guid("47e9bab4-204e-455e-9158-f858d5dad05c"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6886), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6886), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6886) },
                    { new Guid("4a5a7125-a9d9-42e7-9205-1ddff4c593dc"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6893), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6893), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6893) },
                    { new Guid("4b696178-e9c7-4c0d-a9e7-7b42196911f8"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6925), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6925), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6925) },
                    { new Guid("59f98c8a-831c-4ad2-adc2-c5d4e765f594"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6902), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6902), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6902) },
                    { new Guid("64221938-0faf-443c-9772-323d97d8789f"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6953), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6953), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6953) },
                    { new Guid("74cbe29b-62c2-49f2-95cd-d8a776317dd1"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6949), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6949), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6949) },
                    { new Guid("76f5c099-5e27-4d74-a256-7e9a1e8c0e49"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7011), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7011), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7011) },
                    { new Guid("808d4d18-65d9-4231-942e-da11b8448967"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6913), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6913), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6913) },
                    { new Guid("85ae6edc-c081-408c-8f5d-b08fa8e95a2e"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6922), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6922), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6922) },
                    { new Guid("8bf613d7-669b-4aba-9486-0dda10e2fe64"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6890), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6890), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6890) },
                    { new Guid("bcca0f3e-d132-4650-a841-0441b5b84120"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7029), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7029), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7029) },
                    { new Guid("c3a1d595-2d50-4054-948d-45eb8a984598"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6944), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6944), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6944) },
                    { new Guid("c8c0f0ea-4652-463a-a29d-c88dc421de6b"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7005), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7005), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7005) },
                    { new Guid("cb830cdb-ea05-4583-959f-e731e8772ea8"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6919), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6919), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6919) },
                    { new Guid("d4f5674d-ada7-42c0-921a-6f35c95ed0a1"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6930), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6930), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6930) },
                    { new Guid("df536052-0b0b-49f5-bb54-b4ee8dc3802a"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7008), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7008), 4, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7008) },
                    { new Guid("ed23e821-8927-4354-99f9-d2b914ec8aa0"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6907), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6907), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 18, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6907) },
                    { new Guid("ef16a235-334c-47db-8a7a-90c9f1f328bd"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6996), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6996), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6996) },
                    { new Guid("ef4b05fb-56df-415c-ba32-76cf7238730a"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6956), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6956), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 17, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(6956) },
                    { new Guid("f7dce9c4-dc4f-4271-8fc4-244352b371df"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7026), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7026), 0, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7026) },
                    { new Guid("f7f84205-4299-4e2a-a68f-64f7f23227e6"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7000), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7000), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7000) },
                    { new Guid("fcffc134-1570-48bb-bb07-5b48a098a176"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7019), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7019), 3, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), new DateTime(2024, 9, 16, 3, 49, 4, 888, DateTimeKind.Local).AddTicks(7019) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Budgets_RestaurantId",
                table: "Budgets",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseReports_RestaurantId",
                table: "ExpenseReports",
                column: "RestaurantId");

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
                name: "IX_RestaurantMenus_RestaurantId",
                table: "RestaurantMenus",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RestaurantId",
                table: "Reviews",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleReports_RestaurantId",
                table: "SaleReports",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_PaymentMethodId",
                table: "Sales",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_RestaurantId",
                table: "Sales",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_RestaurantMenuId",
                table: "Sales",
                column: "RestaurantMenuId");

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
                name: "SaleReports");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "StockOrders");

            migrationBuilder.DropTable(
                name: "SupplierInventories");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "RestaurantMenus");

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
