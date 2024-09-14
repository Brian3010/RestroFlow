using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestroFlowAPI.Migrations.RestroFlowDb
{
    /// <inheritdoc />
    public partial class IntialSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantItems", x => x.Id);
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RestaurantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RestaurantItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SupplierItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "AlertRecipients",
                columns: table => new
                {
                    AlertRecipientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecipientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InventoryAlertId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlertRecipients", x => x.AlertRecipientId);
                    table.ForeignKey(
                        name: "FK_AlertRecipients_InventoryAlerts_InventoryAlertId",
                        column: x => x.InventoryAlertId,
                        principalTable: "InventoryAlerts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "CreatedAt", "PaymentName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(6455), "EFTPOS", new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(6456) },
                    { new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(6448), "DoorDash", new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(6452) },
                    { new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(6065), "Uber Eats", new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(6214) }
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
                    { new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "88 Kangaroo Court", " Brisbane", " JamesCooper@FFI.com", "James Cooper", "08 9314 7890", new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(1639), "Fresh Food Industries", "VIC", new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(1642) },
                    { new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "23 Sunset Avenue", "Fremantle", "OliviaMiller@GFIFood.com", "Olivia Miller", "03 6234 9087", new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(1645), "GFI Foods", "VIC", new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(1647) },
                    { new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "45 Maple Street", "South Yarra", "SarahJohnso@CFS.com", "Sarah Johnso", "07 3345 6721", new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(1039), "Complete Food Services", "VIC", new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(1629) }
                });

            migrationBuilder.InsertData(
                table: "Budgets",
                columns: new[] { "Id", "BudgetAmount", "BudgetCategory", "BudgetEndDate", "BudgetStartDate", "CreatedAt", "Description", "RestaurantId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1a4a0c16-73a4-4ebe-9b05-326632c686fb"), 400m, "Others", new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7311), new DateTime(2024, 9, 7, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7309), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("60b316a4-be55-463f-bb48-556c9156c2d0"), 1000m, "Labour", new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7307), new DateTime(2024, 9, 7, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7306), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d985b355-0f15-4c8b-bb38-27254ef9e6d9"), 2000m, "Supplies", new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7302), new DateTime(2024, 9, 7, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7300), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Amount", "ExpenseDate", "ExpenseType", "RestaurantId" },
                values: new object[,]
                {
                    { new Guid("0a93be6c-b22f-4347-b4ef-005b9334adfc"), 250m, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6777), "Labour", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("0d9ff582-12b3-4405-ac0a-cfce0197c9a0"), 120m, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6771), "Supplies", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("238f13f9-fa22-410a-97ef-b359893324e5"), 250m, new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6807), "Internet", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("4bef2152-be13-447c-816a-74632bd3ed35"), 120m, new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6825), "Electrictity", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("5103c8f7-92f9-46e1-84a3-cf089015a631"), 100m, new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6795), "Supplies", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("57bf5cdc-6e13-43d7-8607-53af007c211f"), 120m, new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6804), "Electrictity", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("5c7f59d6-7663-49d9-a9ef-22e95258ae62"), 80m, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6780), "Electrictity", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("72908a1e-205e-4140-ba66-a1638939fbe3"), 250m, new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6822), "Labour", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("8c9db985-cb73-4be5-82a0-b7fc36a65087"), 1500m, new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6792), "Rent", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("93271fb5-4ca8-4291-b374-012d405b16bd"), 120m, new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6812), "Water", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("a85240f0-da9f-4079-b48b-44b7513e3bb4"), 120m, new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6834), "Water", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("b381637a-8e29-4968-a2db-23d3db817092"), 120m, new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6829), "Internet", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("be2ac81f-61ab-4ab9-b200-f83dedbc4162"), 120m, new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6800), "Labour", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("d3e2aff6-60b4-4596-a150-0491b12a9051"), 80m, new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6817), "Supplies", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("ddca43f0-cf96-4879-892b-98b2b3d7aea3"), 80m, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6783), "Internet", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("e989a204-88e5-4181-86fd-3b190b765173"), 1500m, new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6814), "Rent", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("eef9ec85-360c-4838-b196-4168ffe0fceb"), 80m, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6789), "Water", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("f46cea01-1473-46f2-84a4-928aa2e0aea0"), 1500m, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6765), "Rent", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") }
                });

            migrationBuilder.InsertData(
                table: "RestaurantItems",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "RestaurantId", "SupplierId", "Unit", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(5506), null, "Chicken wings", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(5508) },
                    { new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(5437), null, "Boneless chicken", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "box", new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(5442) },
                    { new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(5537), null, "Spicy sauce", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(5538) },
                    { new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(5543), null, "Sweet Chiilies", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(5544) },
                    { new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(5521), null, "Marinated beef", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion", new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(5523) },
                    { new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(5548), null, "Wedges", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(5549) },
                    { new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(5527), null, "Chicken powder", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(5528) },
                    { new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(4919), null, "Whole chicken", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "Portion", new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(5072) },
                    { new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(5512), null, "Chicken Steak", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(5513) },
                    { new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(5532), null, "Soy garlic", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 14, 20, 29, 10, 525, DateTimeKind.Local).AddTicks(5533) }
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
                    { new Guid("0a6ad7c2-ea6f-491e-9289-27af236f2d58"), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7409), "Facebook" },
                    { new Guid("12dc6e46-07e0-4755-b1f9-a9392c16525a"), 2f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7377), "Facebook" },
                    { new Guid("33bfbc0e-aeef-48cc-a916-d547d95aaa22"), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7399), "Instagram" },
                    { new Guid("3829b4f5-c310-4bc3-9604-dfb97b36967e"), 2f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7415), "Others" },
                    { new Guid("39bc5328-9ba1-4b75-8dbc-4742ab07946c"), 2f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7385), "Instagram" },
                    { new Guid("4c18623a-134d-42d7-b404-3bff2179e7b8"), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7422), "Instagram" },
                    { new Guid("901aec51-10c0-48ea-9106-3139d24ec738"), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7368), "Google" },
                    { new Guid("bef858da-3d92-410d-b1df-8a001db7d0cc"), 2f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7432), "Others" },
                    { new Guid("d298b3d5-6dba-4827-b7cb-a1e878dc78c2"), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7427), "Facebook" },
                    { new Guid("f6f3b4d4-1f7f-4568-be72-9aa58eac07ee"), 2f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7391), "Instagram" }
                });

            migrationBuilder.InsertData(
                table: "InventoryAlerts",
                columns: new[] { "Id", "CreatedAt", "RestaurantItemId", "Threshold", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0c6d786c-7f5d-478f-bc09-4b5b0ae7062e"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7159), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), 9f, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7162) },
                    { new Guid("37cc5eca-51c3-40db-ae58-8896b341d277"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7220), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), 3f, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7222) },
                    { new Guid("4015c867-6b8a-4c45-9d8c-6154dc0ca62f"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7177), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), 8f, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7179) },
                    { new Guid("4db1f347-4241-463d-aab1-4a4b69dff866"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7171), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), 10f, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7173) },
                    { new Guid("6098f6e8-6634-463e-bb57-3245895bfdde"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7230), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), 10f, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7232) },
                    { new Guid("674fc6a2-f252-4172-b73e-5fc4bd1c95d0"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7207), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), 9f, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7209) },
                    { new Guid("928e6700-9a0f-4d1d-a7e9-89dbbfc168c1"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7185), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), 9f, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7187) },
                    { new Guid("af03fb75-f16e-49eb-b249-d35a87b762bc"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7199), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), 5f, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7201) },
                    { new Guid("c7684f21-4b75-43c6-8de1-7e899d703241"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7191), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), 10f, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7193) },
                    { new Guid("cb7a425f-63fc-4e34-a6d8-6fa63f83a14f"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7214), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), 5f, new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7216) }
                });

            migrationBuilder.InsertData(
                table: "RestaurantInventories",
                columns: new[] { "Id", "LastUdpated", "Quantity", "RestaurantId", "RestaurantItemId", "SupplierId", "Unit" },
                values: new object[,]
                {
                    { new Guid("0850319c-3ce1-4363-851c-e41a40fdaceb"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7030), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("08b51291-7571-41b6-8c21-d1098002ba49"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7070), 9f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("17bb3d6b-c83d-4a03-a9b2-19ff5b662aed"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7047), 9f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "box" },
                    { new Guid("1a954d78-396e-41be-a694-01cfa73c2f55"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6928), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "Portion" },
                    { new Guid("22840a0e-5db8-4461-b286-99fd9a8da5f2"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6898), 22f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "container" },
                    { new Guid("2330a0ca-a35a-447f-9efb-85ab7b99a244"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7080), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("23491a9f-c493-4772-be30-9969f9ed6e6b"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7018), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("2b3cc697-e7d2-44fb-90c7-92672e60a48d"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7035), 22f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("341b80c6-d365-4a30-9bd3-c0dec657cc17"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6907), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("40e10a4c-a1ad-42a4-9b38-5cb5ee2302fc"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6895), 6f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "container" },
                    { new Guid("45688523-72bb-47c4-9f00-6331f53d11bf"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7042), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "Portion" },
                    { new Guid("4c41d3a5-c55e-4052-8c52-b2d893272fdd"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6925), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("4f4a5ea9-175a-489d-9c22-483033304fe8"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7075), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("50c26a6d-8a78-4cf3-90d7-c4108ec0fd40"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7003), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "container" },
                    { new Guid("65601293-eba2-4912-a81f-ffd5dbcc2245"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7087), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("7a78b5b0-1c78-4e22-88cd-6c8294198895"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6884), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "Portion" },
                    { new Guid("7bf5b394-afe0-4ed4-9a18-1f78a7766c19"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7091), 6f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("82ce5a84-4a91-4405-869e-d9c2d85067d8"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7058), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "container" },
                    { new Guid("887fdcd5-2125-4431-9e65-138123fe1a45"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6997), 9f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container" },
                    { new Guid("9b1e7e07-60d3-4bf1-8b49-5ebd856b4aa5"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6932), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "box" },
                    { new Guid("a3d2a437-5bed-4792-93ac-574a87abd363"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7026), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("a6280250-f6db-4abc-98ca-17addb681217"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7007), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "portion" },
                    { new Guid("c7bbe53e-f3f3-4fca-85e6-affb868a6bd0"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6891), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "box" },
                    { new Guid("ccfc628e-60c3-498f-bd56-9f1ebbed07a7"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6903), 6f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion" },
                    { new Guid("d102d814-fa04-4354-9dc7-919aea858348"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6916), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("d8999bb0-1685-4763-9fe7-b68400fd4743"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6911), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("dced3d69-142f-469e-801c-b684c9587de8"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7051), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "container" },
                    { new Guid("e75a8cf8-319c-4654-a376-82c4e1a8188c"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7014), 6f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("e880883a-6221-407b-921b-029bb98a502c"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6919), 6f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("f4556d29-0609-460d-84d3-35c6d8fcbe2d"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(7064), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "PaymentMethodId", "Quantity", "RestaurantId", "RestaurantMenuId", "SaleDate", "TotalAmount" },
                values: new object[,]
                {
                    { new Guid("011e08da-123a-491c-a1d8-b5e43eb5474c"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 20, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("bab92f8b-1fd6-4fbb-9c66-777c49280d54"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6649), 310.0m },
                    { new Guid("05f52b15-99c5-4715-8919-931fe0a5a45c"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 20, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("bab92f8b-1fd6-4fbb-9c66-777c49280d54"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6456), 310.0m },
                    { new Guid("0954da26-9292-4e35-aa6c-72cff9fcd38d"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("6dac4780-fbf3-41f4-8971-b7abdef83a86"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6435), 110.4m },
                    { new Guid("0dccfdc6-7ef0-4633-9142-daf77aeb7ad5"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 12, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("bab92f8b-1fd6-4fbb-9c66-777c49280d54"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6566), 186.0m },
                    { new Guid("0e4d285b-6328-4c1b-a5be-9826a613ab1d"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 15, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("6e4aaccc-3c0d-4d91-a8e0-10e1a70a24f2"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6671), 225m },
                    { new Guid("1972b367-b421-4fa2-a85e-403d14e0f1cc"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("6dac4780-fbf3-41f4-8971-b7abdef83a86"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6521), 13.8m },
                    { new Guid("1e5e04ee-b00b-4b37-ba45-fa6ba7f2f6e6"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 11, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("d5d66b38-5140-485b-8575-f83d5fae6a5f"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6620), 176m },
                    { new Guid("21eb4242-9917-44b2-ae93-d65cf8f31766"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 15, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("fc693bcd-807b-4506-a8fd-dc3e31905a81"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6439), 217.5m },
                    { new Guid("24131f61-6ea3-42a3-8c43-fffdbc2595ea"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 10, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("45859bd4-b0bd-4491-8b1b-7c33a940df8a"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6608), 170m },
                    { new Guid("292704ff-936f-4829-be2a-57570af038cb"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("d5d66b38-5140-485b-8575-f83d5fae6a5f"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6511), 256m },
                    { new Guid("2a036ac6-b7d2-4909-a8c3-60d750183525"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 11, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("6dac4780-fbf3-41f4-8971-b7abdef83a86"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6630), 75.9m },
                    { new Guid("2b868ef6-6bc7-4227-a9c1-9c9f3d5e7051"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("19924c8f-32e0-4c3d-b425-995ed0ddca5a"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6505), 37.0m },
                    { new Guid("3120d98f-8e85-4b91-b908-318be6194490"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 11, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("9ca19c31-2e04-42e7-8cad-6e61bd177eaf"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6349), 462m },
                    { new Guid("37362e4b-d87f-496e-a55a-50242ba4e649"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f6c1d21b-b9dd-452f-8e14-364f530bf7b8"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6665), 16.5m },
                    { new Guid("4b2edfdf-c993-41c8-8337-5bcf1950c638"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 11, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("29585767-ced3-46a6-8f1f-06455c4b1172"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6639), 148.5m },
                    { new Guid("4f425374-8f23-4f73-b2db-c3faed184ae1"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("d02988c8-bd91-400d-8593-403c285c6dfb"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6577), 28m },
                    { new Guid("5235b027-629c-4465-9c79-2d01e0b3f0de"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 10, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("dd636f75-f510-47eb-bfc8-cf2613defdba"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6429), 145.0m },
                    { new Guid("52645748-0676-44fb-89ae-44fd9943faf9"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 18, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("75734df5-e59e-4d9e-a224-ed8e4ae67fdd"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6655), 180m },
                    { new Guid("54c79c29-3eb1-4067-8c15-29a6bd9dc0ca"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 11, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f6c1d21b-b9dd-452f-8e14-364f530bf7b8"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6581), 181.5m },
                    { new Guid("55223675-6631-4cbe-a789-5514771083cc"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 20, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("9ca19c31-2e04-42e7-8cad-6e61bd177eaf"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6591), 840m },
                    { new Guid("59ed7c5b-8076-4573-b1ed-f9f06114e681"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 20, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("4d165d8f-fbcf-4144-a318-374e7f08cb57"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6400), 800m },
                    { new Guid("61705ca6-8ce1-47d2-941c-04cb485351d2"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 18, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("1d74b052-3b59-465f-add2-d91f96b8961a"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6604), 378m },
                    { new Guid("7c84df89-82c2-4e84-bf77-066bb556fdc0"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 11, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("45859bd4-b0bd-4491-8b1b-7c33a940df8a"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6411), 187m },
                    { new Guid("7ffc51bb-e35f-4981-b4f9-53cebfa702a8"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 20, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("fc693bcd-807b-4506-a8fd-dc3e31905a81"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6549), 290.0m },
                    { new Guid("829b2721-ae55-4e4a-b65b-9f6c70073a44"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 15, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("19924c8f-32e0-4c3d-b425-995ed0ddca5a"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6417), 277.5m },
                    { new Guid("86787c8c-10ff-4a78-b2cf-649dd2df0e2b"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("4d165d8f-fbcf-4144-a318-374e7f08cb57"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6598), 640m },
                    { new Guid("87218ad0-886b-42df-b339-5f9f0d53680d"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 12, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("07a67762-a063-46db-94d1-080237b187a5"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6562), 192m },
                    { new Guid("90684023-0842-45e2-915e-d94c077d028c"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 11, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("dd636f75-f510-47eb-bfc8-cf2613defdba"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6624), 159.5m },
                    { new Guid("933b2075-6036-4e43-a6b4-9201ad655677"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 12, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("4d165d8f-fbcf-4144-a318-374e7f08cb57"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6489), 480m },
                    { new Guid("94c32373-a48e-4a4d-bf6f-1610341c2217"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 15, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("d5d66b38-5140-485b-8575-f83d5fae6a5f"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6425), 240m },
                    { new Guid("984e71f4-3c09-428c-82d0-190589c745dd"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 15, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("75734df5-e59e-4d9e-a224-ed8e4ae67fdd"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6462), 150m },
                    { new Guid("99899390-52dc-4325-886b-8396e93861a9"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("d02988c8-bd91-400d-8593-403c285c6dfb"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6468), 28m },
                    { new Guid("a4253507-0f3f-4797-b098-b4eb4da5a517"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 12, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("d02988c8-bd91-400d-8593-403c285c6dfb"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6661), 336m },
                    { new Guid("a97a1f43-8e5b-40f5-9f17-8b5bc308db10"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 20, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("75734df5-e59e-4d9e-a224-ed8e4ae67fdd"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6571), 200m },
                    { new Guid("b08fbe2e-f6a5-4740-aabf-02911dcf767c"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("45859bd4-b0bd-4491-8b1b-7c33a940df8a"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6499), 272m },
                    { new Guid("b358a9a1-5da4-456a-9312-e96e91262f54"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("9ca19c31-2e04-42e7-8cad-6e61bd177eaf"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6482), 84m },
                    { new Guid("b3e0e8a3-f84a-4a07-b450-52dda51ae723"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("6e4aaccc-3c0d-4d91-a8e0-10e1a70a24f2"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6587), 30m },
                    { new Guid("b98793e4-23fa-4644-bf65-f9d1b3e56dae"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("dd636f75-f510-47eb-bfc8-cf2613defdba"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6515), 232.0m },
                    { new Guid("bb31d780-6015-419f-bdac-9a170c091981"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("29585767-ced3-46a6-8f1f-06455c4b1172"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6446), 13.5m },
                    { new Guid("c0e7f633-ddbc-4339-8707-47a8fb592c98"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 20, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("29585767-ced3-46a6-8f1f-06455c4b1172"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6556), 270.0m },
                    { new Guid("c24544d1-906b-4025-a533-0c1b1a0f8f15"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 15, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("6e4aaccc-3c0d-4d91-a8e0-10e1a70a24f2"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6478), 225m },
                    { new Guid("c30c0d2d-c6ec-49d4-b780-dba4185571e1"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 11, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("07a67762-a063-46db-94d1-080237b187a5"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6645), 176m },
                    { new Guid("d135b32e-1a23-461a-b924-f6cfbbe9d852"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 12, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("07a67762-a063-46db-94d1-080237b187a5"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6452), 192m },
                    { new Guid("d992eb83-3055-4e57-95ce-2be49027d8a2"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("fc693bcd-807b-4506-a8fd-dc3e31905a81"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6634), 232.0m },
                    { new Guid("da0a9bf0-7b20-4585-9ee3-6aac02f50570"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("1d74b052-3b59-465f-add2-d91f96b8961a"), new DateTime(2024, 9, 13, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6495), 336m },
                    { new Guid("ec1f4df5-001a-404f-b72f-66d9d63a7bf9"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("1d74b052-3b59-465f-add2-d91f96b8961a"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6407), 336m },
                    { new Guid("fb506b42-7353-4f64-80ae-80a1375a183c"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 10, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("19924c8f-32e0-4c3d-b425-995ed0ddca5a"), new DateTime(2024, 9, 12, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6614), 185.0m },
                    { new Guid("ff27ae7c-46da-4122-9fcb-d80506b1a752"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f6c1d21b-b9dd-452f-8e14-364f530bf7b8"), new DateTime(2024, 9, 14, 20, 29, 10, 804, DateTimeKind.Local).AddTicks(6472), 264.0m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlertRecipients_InventoryAlertId",
                table: "AlertRecipients",
                column: "InventoryAlertId");

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
                name: "InventoryAlerts");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "RestaurantMenus");

            migrationBuilder.DropTable(
                name: "SupplierItems");

            migrationBuilder.DropTable(
                name: "RestaurantItems");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
