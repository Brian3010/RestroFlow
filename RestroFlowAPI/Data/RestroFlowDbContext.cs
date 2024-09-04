
using Microsoft.EntityFrameworkCore;
using RestroFlowAPI.Models;

namespace RestroFlowAPI.Data
{
  public class RestroFlowDbContext : DbContext
  {
    public RestroFlowDbContext(DbContextOptions<RestroFlowDbContext> dbContextOptions) : base(dbContextOptions) {

    }

    // Create tables
    public DbSet<AlertRecipient> AlertRecipients { get; set; }
    public DbSet<Budget> Budgets { get; set; }
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<ExpenseReport> ExpenseReports { get; set; }
    public DbSet<IncomeSource> IncomeSources { get; set; }
    public DbSet<InventoryAlert> InventoryAlerts { get; set; }
    public DbSet<InventoryReport> InventoryReports { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<RestaurantInventory> RestaurantInventories { get; set; }
    public DbSet<RestaurantItem> RestaurantItems { get; set; }
    public DbSet<RestaurantMenu> RestaurantMenus { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<SaleReport> SaleReports { get; set; }
    public DbSet<StockOrder> StockOrders { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<SupplierInventory> SupplierInventories { get; set; }
    public DbSet<SupplierItem> SupplierItems { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder) {

      // Restaurant Inventory
      modelBuilder.Entity<RestaurantInventory>()
          .HasOne(ri => ri.Restaurant)
          .WithMany()
          .HasForeignKey(ri => ri.RestaurantId)
          .OnDelete(DeleteBehavior.NoAction);  // Set to null on delete

      modelBuilder.Entity<RestaurantInventory>()
          .HasOne(ri => ri.RestaurantItem)
          .WithMany()
          .HasForeignKey(ri => ri.RestaurantItemId)
          .OnDelete(DeleteBehavior.NoAction);  // Set to null on delete

      modelBuilder.Entity<RestaurantInventory>()
          .HasOne(ri => ri.Supplier)
          .WithMany()
          .HasForeignKey(ri => ri.SupplierId)
          .OnDelete(DeleteBehavior.NoAction);  // Set to null on delete


      // Stock Order
      modelBuilder.Entity<StockOrder>()
          .HasOne(ri => ri.Supplier)
          .WithMany()
          .HasForeignKey(ri => ri.SupplierId)
          .OnDelete(DeleteBehavior.NoAction);  // Set to null on delete

      modelBuilder.Entity<StockOrder>()
          .HasOne(ri => ri.RestaurantItem)
          .WithMany()
          .HasForeignKey(ri => ri.RestaurantItemId)
          .OnDelete(DeleteBehavior.NoAction);  // Set to null on delete

      modelBuilder.Entity<StockOrder>()
          .HasOne(ri => ri.Restaurant)
          .WithMany()
          .HasForeignKey(ri => ri.RestaurantId)
          .OnDelete(DeleteBehavior.NoAction);  // Set to null on delete

      // Sale
      modelBuilder.Entity<Sale>()
          .HasOne(ri => ri.RestaurantMenus)
          .WithMany()
          .HasForeignKey(ri => ri.RestaurantMenuId)
          .OnDelete(DeleteBehavior.NoAction);  // Set to null on delete

      modelBuilder.Entity<Sale>()
          .HasOne(ri => ri.IncomeSources)
          .WithMany()
          .HasForeignKey(ri => ri.IncomeSourceId)
          .OnDelete(DeleteBehavior.NoAction);  // Set to null on delete

      modelBuilder.Entity<Sale>()
          .HasOne(ri => ri.Restaurant)
          .WithMany()
          .HasForeignKey(ri => ri.RestaurantId)
          .OnDelete(DeleteBehavior.NoAction);  // Set to null on delete

      // Supplier Inventory
      modelBuilder.Entity<SupplierInventory>()
          .HasOne(ri => ri.Supplier)
          .WithMany()
          .HasForeignKey(ri => ri.SupplierId)
          .OnDelete(DeleteBehavior.NoAction);  // Set to null on delete

      modelBuilder.Entity<SupplierInventory>()
          .HasOne(ri => ri.SupplierItems)
          .WithMany()
          .HasForeignKey(ri => ri.SupplierItemId)
          .OnDelete(DeleteBehavior.NoAction);  // Set to null on delete

    }





  }
}
