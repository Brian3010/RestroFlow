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
                    AlertType = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    InventoryAlertId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecipientId = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    { new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(8336), "EFTPOS", new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(8338) },
                    { new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(8326), "DoorDash", new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(8332) },
                    { new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(7927), "Uber Eats", new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(8092) }
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
                    { new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "88 Kangaroo Court", " Brisbane", " JamesCooper@FFI.com", "James Cooper", "08 9314 7890", new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(3272), "Fresh Food Industries", "VIC", new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(3274) },
                    { new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "23 Sunset Avenue", "Fremantle", "OliviaMiller@GFIFood.com", "Olivia Miller", "03 6234 9087", new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(3279), "GFI Foods", "VIC", new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(3280) },
                    { new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "45 Maple Street", "South Yarra", "SarahJohnso@CFS.com", "Sarah Johnso", "07 3345 6721", new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(2552), "Complete Food Services", "VIC", new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(3261) }
                });

            migrationBuilder.InsertData(
                table: "Budgets",
                columns: new[] { "Id", "BudgetAmount", "BudgetCategory", "BudgetEndDate", "BudgetStartDate", "CreatedAt", "Description", "RestaurantId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("11985f4b-5289-47a9-ad39-187d6c4cca12"), 2000m, "Supplies", new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5282), new DateTime(2024, 9, 6, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5279), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8436090f-ed4d-4b2c-b73e-647b616539d4"), 1000m, "Labour", new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5286), new DateTime(2024, 9, 6, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5285), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("92a8a19e-ef3f-4877-a9e3-9b7a3575fbbe"), 400m, "Others", new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5288), new DateTime(2024, 9, 6, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5287), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Amount", "ExpenseDate", "ExpenseType", "RestaurantId" },
                values: new object[,]
                {
                    { new Guid("05ab09ca-994c-48ff-8cb0-538ea3cfe6a4"), 80m, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4878), "Electrictity", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("1a43dc78-0aa5-4f4d-ad1c-4f3f78752dd8"), 100m, new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4893), "Labour", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("1abcf2cf-4d30-46a9-a569-9f39b61388a9"), 250m, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4885), "Water", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("3edcae09-642a-4d29-aa53-e0ee4ded0069"), 250m, new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4896), "Electrictity", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("410855fc-a649-4717-8b39-5d7be2ed1206"), 120m, new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4889), "Supplies", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("4c32f1ed-57db-44ff-b9f0-d7edafd56b5f"), 120m, new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4917), "Water", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("5a9a1b82-a296-450c-8d48-aa58d13b02bb"), 100m, new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4914), "Internet", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("62d4cdd9-9661-4177-ae99-d4213e74e564"), 100m, new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4911), "Electrictity", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("701996b9-7135-4c2b-9323-49f717c08767"), 250m, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4876), "Labour", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("8e9df0eb-63d4-4469-a1e5-8fd4326aeec1"), 1500m, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4866), "Rent", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("cbae00f7-761b-468c-b950-a5841964665a"), 100m, new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4899), "Internet", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("d16c4469-d0d0-41c1-8609-a17191b4b3f6"), 1500m, new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4887), "Rent", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("d9298e1a-4726-42d4-8b3c-5e44120d6bb2"), 250m, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4871), "Supplies", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("dd9d21ff-09d4-42bf-8df0-0c968d891bcf"), 250m, new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4905), "Supplies", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("e6dea5d3-5de5-4f22-8a17-457aacf14e9c"), 80m, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4881), "Internet", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("f318a004-4b0e-4fa0-9a2f-6ac364f7bffe"), 1500m, new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4903), "Rent", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("f42e063e-5c97-468e-a1c6-e97d48682114"), 250m, new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4909), "Labour", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") },
                    { new Guid("fa547945-ea39-479f-8719-c0e1937f93e1"), 250m, new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4902), "Water", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1") }
                });

            migrationBuilder.InsertData(
                table: "RestaurantItems",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "RestaurantId", "SupplierId", "Unit", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(7293), null, "Chicken wings", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(7294) },
                    { new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(7280), null, "Boneless chicken", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "box", new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(7287) },
                    { new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(7326), null, "Spicy sauce", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(7328) },
                    { new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(7334), null, "Sweet Chiilies", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(7335) },
                    { new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(7307), null, "Marinated beef", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion", new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(7309) },
                    { new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(7340), null, "Wedges", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(7341) },
                    { new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(7314), null, "Chicken powder", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(7316) },
                    { new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(6584), null, "Whole chicken", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "Portion", new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(6762) },
                    { new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(7299), null, "Chicken Steak", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container", new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(7301) },
                    { new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(7320), null, "Soy garlic", new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag", new DateTime(2024, 9, 13, 2, 28, 37, 606, DateTimeKind.Local).AddTicks(7322) }
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
                    { new Guid("00ff3057-a844-4251-971c-7f27e6394060"), 2f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5350), "Others" },
                    { new Guid("03e08c7f-7b25-4d26-84f4-b7f51e3d0577"), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5354), "Facebook" },
                    { new Guid("1a30abc3-26a4-4d90-ab98-5c5275570cff"), 2f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5342), "Google" },
                    { new Guid("201f75df-1bc8-4601-9a36-24e03137c0d3"), 2f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5339), "Others" },
                    { new Guid("35e9d6a7-20ac-44c0-83db-dd66f4be978c"), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5327), "Facebook" },
                    { new Guid("43bc9a43-c2b9-47c5-b07f-c28908048458"), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5323), "Facebook" },
                    { new Guid("48389866-88f4-478f-8e2c-e016b3113999"), 2f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5331), "Facebook" },
                    { new Guid("4991744f-7524-411a-9260-44aa8aa4ce10"), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5346), "Google" },
                    { new Guid("5fa3cb70-e50d-4c6f-9c4a-8e9a565c4e79"), 2f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5318), "Facebook" },
                    { new Guid("82d8c098-9bba-4562-86cb-bad16e34077d"), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), null, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5334), "Facebook" }
                });

            migrationBuilder.InsertData(
                table: "InventoryAlerts",
                columns: new[] { "Id", "AlertType", "CreatedAt", "RestaurantItemId", "Threshold", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1177a4e7-a0ed-4441-805f-7f938e50a42b"), "Low Stock", new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5171), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), 5f, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5172) },
                    { new Guid("2d9d56aa-8335-4680-93c9-2eddeeb7c2e6"), "Low Stock", new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5179), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), 3f, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5180) },
                    { new Guid("8dbe8adf-11dd-4e47-8797-edad9a130324"), "Low Stock", new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5188), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), 10f, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5189) },
                    { new Guid("a0ea3b70-0522-4899-a2bc-a37e8b9d67f2"), "Low Stock", new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5193), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), 20f, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5194) },
                    { new Guid("a591d220-0ed8-4c25-a80b-032436e5e390"), "Low Stock", new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5184), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), 25f, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5185) },
                    { new Guid("aa77aa59-f939-4508-95ab-475e8ee54fd2"), "Low Stock", new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5156), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), 10f, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5158) },
                    { new Guid("bdaa92e4-e425-4f37-a214-d91ce3827588"), "Low Stock", new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5197), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), 3f, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5198) },
                    { new Guid("cfea7b2c-1e5f-40d9-a0a7-8bb0af703e01"), "Low Stock", new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5162), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), 20f, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5163) },
                    { new Guid("d7dce05d-be63-4dd2-bbf0-7c330e4b077d"), "Low Stock", new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5174), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), 25f, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5175) },
                    { new Guid("dead3800-f081-4490-8b21-3585be3e15df"), "Low Stock", new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5165), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), 5f, new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5166) }
                });

            migrationBuilder.InsertData(
                table: "RestaurantInventories",
                columns: new[] { "Id", "LastUdpated", "Quantity", "RestaurantId", "RestaurantItemId", "SupplierId", "Unit" },
                values: new object[,]
                {
                    { new Guid("15659011-2b6b-4f4a-9fcf-54126e1065cc"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5105), 22f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("26e2561a-793a-4e64-8fa0-98956a35a51e"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5039), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("2db956f4-0ec3-4fbd-ba46-f587aa82463b"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5066), 22f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("37d9da3b-0dc1-404d-8188-9bf197154a0b"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4994), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion" },
                    { new Guid("42533065-8ed3-4d6c-bd4e-cf1c1204b409"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5047), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("50deaf6d-666d-408e-91ba-8d007556f5f6"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5032), 22f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("5534ea5a-f4ff-4169-b31b-09f8eee610cc"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5109), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("5991cbc0-93d2-48ae-89e6-fe97fea21afa"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5050), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "Portion" },
                    { new Guid("5c948061-db45-4a13-95f4-d2f936f1e622"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5077), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("620a1cc8-ac4f-43c4-80bb-d5c68481f49b"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5074), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("51a801ff-89b7-4663-a308-b0b577018e14"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("6a3423cd-e0d3-4f6a-92e6-25cbe9a71ce7"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5053), 4f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "box" },
                    { new Guid("6afcf842-06fa-4fb7-b7bb-f01a9ad79db3"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5036), 9f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("760885b4-1e50-41c1-8349-732c69d5155c"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4975), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "Portion" },
                    { new Guid("77e9f92a-5cbc-4074-b636-9aafc292f31b"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5083), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "Portion" },
                    { new Guid("83bdb3e3-60f4-472b-afdd-3d78725af3d4"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5102), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "bag" },
                    { new Guid("8a717094-c949-44d6-bfca-66f94ae237d1"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4990), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "container" },
                    { new Guid("a744c61c-782b-4fab-9860-d97b06dcf088"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5086), 22f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "box" },
                    { new Guid("abcfbd08-0c89-40d4-8b02-1be88de6f315"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4986), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "container" },
                    { new Guid("b18f94b4-9327-4ee1-8518-e9a833e693b7"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5079), 5f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "bag" },
                    { new Guid("b33340ed-4a90-4f03-a389-cf3ef1afec73"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5090), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "container" },
                    { new Guid("b35e5c1b-1360-4049-90f9-4f5ba643178d"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5064), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("114288a7-a300-42c6-8578-5f52df5ce147"), "portion" },
                    { new Guid("b70b2112-291c-41c9-b5b6-51fcaeb783fb"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5043), 6f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("cb84a3d5-c387-44de-a7f0-50f5f5d413c0"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5093), 6f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"), "container" },
                    { new Guid("d867145a-1cde-4348-93ea-09e500a09ae2"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5095), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "portion" },
                    { new Guid("dfacaed3-0809-43f3-a2b8-3827c151c5ac"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5057), 22f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "container" },
                    { new Guid("e369f426-1517-4070-b147-9280883b1828"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5112), 11f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" },
                    { new Guid("f09f63c5-1b63-45bd-97ee-a49e89859dc5"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5069), 12f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"), new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), "bag" },
                    { new Guid("f465256d-adaa-44bd-a37e-e3ccf20b149e"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5060), 1f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "container" },
                    { new Guid("fb4ee3f9-1ac4-4701-8efb-8148a764da53"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4983), 10f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "box" },
                    { new Guid("fb612e81-299d-4fdd-854e-72541d7bfed6"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(5100), 3f, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"), new Guid("cf762d80-3731-4d9d-af92-b77f99676005"), "bag" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "PaymentMethodId", "Quantity", "RestaurantId", "RestaurantMenuId", "SaleDate", "TotalAmount" },
                values: new object[,]
                {
                    { new Guid("03771e5c-fe00-42ce-a0b3-aa3826293b8f"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("29585767-ced3-46a6-8f1f-06455c4b1172"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4727), 13.5m },
                    { new Guid("07568314-3060-41cc-a880-850457f58640"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 20, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("6dac4780-fbf3-41f4-8971-b7abdef83a86"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4719), 138.0m },
                    { new Guid("0dc40bd1-6f9b-43bf-9043-7732a8803a19"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 12, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("d5d66b38-5140-485b-8575-f83d5fae6a5f"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4557), 192m },
                    { new Guid("0ec95745-c762-4785-b3da-cd7ab8d68fe4"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 10, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("6e4aaccc-3c0d-4d91-a8e0-10e1a70a24f2"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4800), 150m },
                    { new Guid("123bdd23-7a76-4032-9563-76ad42fd8419"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 12, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("29585767-ced3-46a6-8f1f-06455c4b1172"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4574), 162.0m },
                    { new Guid("1278b420-b938-4639-8874-c4a61d4dd1ed"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f6c1d21b-b9dd-452f-8e14-364f530bf7b8"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4795), 33.0m },
                    { new Guid("16376ee2-3feb-410e-add3-f0d0154db5be"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("dd636f75-f510-47eb-bfc8-cf2613defdba"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4560), 232.0m },
                    { new Guid("164ec604-3bc6-4673-9581-68095508d67d"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 20, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("6e4aaccc-3c0d-4d91-a8e0-10e1a70a24f2"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4684), 300m },
                    { new Guid("237d2b0e-c38c-468f-ad9a-9fb1180ad4cd"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("4d165d8f-fbcf-4144-a318-374e7f08cb57"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4535), 640m },
                    { new Guid("2e78f6bd-d4b8-4c05-9472-925ee4cb7512"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 20, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("dd636f75-f510-47eb-bfc8-cf2613defdba"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4645), 290.0m },
                    { new Guid("36d727dd-69f0-4122-94d1-050ead021a19"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 12, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("4d165d8f-fbcf-4144-a318-374e7f08cb57"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4693), 480m },
                    { new Guid("3917913b-cfa2-45dc-b54b-4d90d482f6cd"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 15, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("07a67762-a063-46db-94d1-080237b187a5"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4663), 240m },
                    { new Guid("4ed81407-a662-4fbd-a189-35d8d36a850f"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 18, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("07a67762-a063-46db-94d1-080237b187a5"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4579), 288m },
                    { new Guid("52f8b59d-8552-4756-8169-abfe20cf65da"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 18, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("07a67762-a063-46db-94d1-080237b187a5"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4731), 288m },
                    { new Guid("53c16e82-e795-4468-aa79-43dc97a7604a"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 20, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("1d74b052-3b59-465f-add2-d91f96b8961a"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4541), 420m },
                    { new Guid("648e1766-01e6-4731-a506-d52e5eed63e0"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("45859bd4-b0bd-4491-8b1b-7c33a940df8a"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4545), 17m },
                    { new Guid("6d111ea5-8c18-458f-9d8c-ca13b685c15b"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 10, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("dd636f75-f510-47eb-bfc8-cf2613defdba"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4714), 145.0m },
                    { new Guid("7620851e-7b90-46b9-9f2c-332995aea462"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("fc693bcd-807b-4506-a8fd-dc3e31905a81"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4655), 232.0m },
                    { new Guid("7a473eb0-0686-46a5-9918-fb6cd8f3979e"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("bab92f8b-1fd6-4fbb-9c66-777c49280d54"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4667), 31.0m },
                    { new Guid("7d31c685-46f4-4598-926f-f261ce29fb3f"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 15, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("6dac4780-fbf3-41f4-8971-b7abdef83a86"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4650), 103.5m },
                    { new Guid("891f595f-f10a-4dab-a088-306a677d8feb"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 11, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("9ca19c31-2e04-42e7-8cad-6e61bd177eaf"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4476), 462m },
                    { new Guid("8f6ab32a-a5fa-4169-9dce-648a17639183"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f6c1d21b-b9dd-452f-8e14-364f530bf7b8"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4679), 33.0m },
                    { new Guid("90418ae4-b8df-43ee-9266-0f7a010ed6a8"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 15, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("19924c8f-32e0-4c3d-b425-995ed0ddca5a"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4706), 277.5m },
                    { new Guid("90a4cfb7-eb27-49a5-a8e2-50a2f32df498"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("bab92f8b-1fd6-4fbb-9c66-777c49280d54"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4582), 248.0m },
                    { new Guid("91d72a4b-56a0-4680-921f-3cefa7b3c43a"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("45859bd4-b0bd-4491-8b1b-7c33a940df8a"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4701), 272m },
                    { new Guid("95cb092f-80eb-4162-b6d0-1a54d4e1be30"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("bab92f8b-1fd6-4fbb-9c66-777c49280d54"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4735), 248.0m },
                    { new Guid("b18026c7-fd96-4506-a168-83cbbe78cf75"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("d02988c8-bd91-400d-8593-403c285c6dfb"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4591), 448m },
                    { new Guid("b26eec95-4905-4e7c-9f64-ee4ea3347239"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 20, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("9ca19c31-2e04-42e7-8cad-6e61bd177eaf"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4604), 840m },
                    { new Guid("b4399d3d-59d3-4dae-bc1a-854c3a8066a3"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 12, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("6dac4780-fbf3-41f4-8971-b7abdef83a86"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4565), 82.8m },
                    { new Guid("bb48fd7a-b769-4b2e-b5c6-8e488b2967fd"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("6e4aaccc-3c0d-4d91-a8e0-10e1a70a24f2"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4599), 30m },
                    { new Guid("be59ee49-4d86-4435-abb1-ebda442e34d4"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 15, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("fc693bcd-807b-4506-a8fd-dc3e31905a81"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4723), 217.5m },
                    { new Guid("bfe005d8-6a63-4316-bee7-c36259e55067"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("19924c8f-32e0-4c3d-b425-995ed0ddca5a"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4637), 18.5m },
                    { new Guid("c32b6dd8-0a1e-49a3-adde-878ae726bf6d"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("45859bd4-b0bd-4491-8b1b-7c33a940df8a"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4632), 272m },
                    { new Guid("c32bab4e-7218-4088-ad5d-74137414e75b"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 11, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("9ca19c31-2e04-42e7-8cad-6e61bd177eaf"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4689), 462m },
                    { new Guid("c98dfe6b-0ef1-4a27-8775-738a202390a3"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("1d74b052-3b59-465f-add2-d91f96b8961a"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4698), 42m },
                    { new Guid("cb97587d-07ef-4bf2-8f58-e7906ca76211"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("fc693bcd-807b-4506-a8fd-dc3e31905a81"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4570), 232.0m },
                    { new Guid("cc08936a-7d04-4bfa-a88f-08056e5dc2c3"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("19924c8f-32e0-4c3d-b425-995ed0ddca5a"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4550), 37.0m },
                    { new Guid("d4253e69-5beb-4d48-8379-d8112470cb07"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 20, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("29585767-ced3-46a6-8f1f-06455c4b1172"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4658), 270.0m },
                    { new Guid("d52ec97c-afba-4759-9466-fa03e8c36c4b"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 15, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("1d74b052-3b59-465f-add2-d91f96b8961a"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4613), 315m },
                    { new Guid("d56f791d-884f-4f94-adae-a967f357a647"), new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"), 10, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("f6c1d21b-b9dd-452f-8e14-364f530bf7b8"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4595), 165.0m },
                    { new Guid("d710a1b2-7d67-4615-8211-c2d8a8e8cace"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 15, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("d02988c8-bd91-400d-8593-403c285c6dfb"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4676), 420m },
                    { new Guid("d81e89bd-9a5c-41c5-8435-3f07df52f7af"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 1, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("d02988c8-bd91-400d-8593-403c285c6dfb"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4791), 28m },
                    { new Guid("ded7d351-4cc6-40ae-a4de-3fea48fd6d46"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 10, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("d5d66b38-5140-485b-8575-f83d5fae6a5f"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4641), 160m },
                    { new Guid("dfe54a7a-b9da-462c-ad55-904dda407612"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("4d165d8f-fbcf-4144-a318-374e7f08cb57"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4608), 640m },
                    { new Guid("e0d4890c-7708-4d18-9ac8-a68d2e3ced19"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 11, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("75734df5-e59e-4d9e-a224-ed8e4ae67fdd"), new DateTime(2024, 9, 13, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4587), 110m },
                    { new Guid("eedf2f42-59b6-4674-be42-133a67f901d7"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 16, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("d5d66b38-5140-485b-8575-f83d5fae6a5f"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4711), 256m },
                    { new Guid("f082992a-40ca-404b-b39a-9137cff26996"), new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"), 11, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("75734df5-e59e-4d9e-a224-ed8e4ae67fdd"), new DateTime(2024, 9, 12, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4672), 110m },
                    { new Guid("f10fcdfe-cadf-4bd1-8baa-a0b03c2a2a1f"), new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"), 2, new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), new Guid("75734df5-e59e-4d9e-a224-ed8e4ae67fdd"), new DateTime(2024, 9, 11, 2, 28, 37, 882, DateTimeKind.Local).AddTicks(4786), 20m }
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
