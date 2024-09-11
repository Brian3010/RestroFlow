﻿
using Microsoft.EntityFrameworkCore;
using RestroFlowAPI.Models;
using RestroFlowAPI.Seeds;

namespace RestroFlowAPI.Data
{
  public class RestroFlowDbContext : DbContext
  {
    public RestroFlowDbContext(DbContextOptions<RestroFlowDbContext> dbContextOptions) : base(dbContextOptions) {

    }

    // Create tables
    public DbSet<AlertRecipient> AlertRecipients { get; set; }
    public DbSet<Budgets> Budgets { get; set; }
    public DbSet<Expenses> Expenses { get; set; }
    public DbSet<ExpenseReports> ExpenseReports { get; set; }
    public DbSet<PaymentMethods> PaymentMethods { get; set; }
    public DbSet<InventoryAlerts> InventoryAlerts { get; set; }
    public DbSet<InventoryReports> InventoryReports { get; set; }
    public DbSet<Restaurants> Restaurants { get; set; }
    public DbSet<RestaurantInventories> RestaurantInventories { get; set; }
    public DbSet<RestaurantItems> RestaurantItems { get; set; }
    public DbSet<RestaurantMenus> RestaurantMenus { get; set; }
    public DbSet<Reviews> Reviews { get; set; }
    public DbSet<Sales> Sales { get; set; }
    public DbSet<SaleReports> SaleReports { get; set; }
    public DbSet<StockOrders> StockOrders { get; set; }
    public DbSet<Suppliers> Suppliers { get; set; }
    public DbSet<SupplierInventories> SupplierInventories { get; set; }
    public DbSet<SupplierItems> SupplierItems { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder) {
      base.OnModelCreating(modelBuilder);

      // Restaurant Inventory
      modelBuilder.Entity<RestaurantInventories>()
          .HasOne(ri => ri.Restaurant)
          .WithMany()
          .HasForeignKey(ri => ri.RestaurantId)
          .OnDelete(DeleteBehavior.NoAction);  // Set to null on delete

      modelBuilder.Entity<RestaurantInventories>()
          .HasOne(ri => ri.RestaurantItem)
          .WithMany()
          .HasForeignKey(ri => ri.RestaurantItemId)
          .OnDelete(DeleteBehavior.NoAction);  // Set to null on delete

      modelBuilder.Entity<RestaurantInventories>()
         .HasOne(ri => ri.Supplier)
         .WithMany()
         .HasForeignKey(ri => ri.SupplierId)
         .OnDelete(DeleteBehavior.NoAction);

      // Restaurant Item
      modelBuilder.Entity<RestaurantItems>()
         .HasOne(ri => ri.Supplier)
         .WithMany()
         .HasForeignKey(ri => ri.SupplierId)
         .OnDelete(DeleteBehavior.NoAction);  // Set to null on delete

      modelBuilder.Entity<RestaurantItems>()
       .HasOne(ri => ri.Restaurant)
       .WithMany()
       .HasForeignKey(ri => ri.RestaurantId)
       .OnDelete(DeleteBehavior.NoAction);

      // Stock Order
      modelBuilder.Entity<StockOrders>()
          .HasOne(ri => ri.Supplier)
          .WithMany()
          .HasForeignKey(ri => ri.SupplierId)
          .OnDelete(DeleteBehavior.NoAction);  // Set to null on delete

      modelBuilder.Entity<StockOrders>()
          .HasOne(ri => ri.RestaurantItem)
          .WithMany()
          .HasForeignKey(ri => ri.RestaurantItemId)
          .OnDelete(DeleteBehavior.NoAction);  // Set to null on delete

      modelBuilder.Entity<StockOrders>()
          .HasOne(ri => ri.Restaurant)
          .WithMany()
          .HasForeignKey(ri => ri.RestaurantId)
          .OnDelete(DeleteBehavior.NoAction);  // Set to null on delete

      // Sale
      modelBuilder.Entity<Sales>()
          .HasOne(ri => ri.RestaurantMenus)
          .WithMany()
          .HasForeignKey(ri => ri.RestaurantMenuId)
          .OnDelete(DeleteBehavior.NoAction);  // Set to null on delete

      modelBuilder.Entity<Sales>()
          .HasOne(ri => ri.PaymentMethods)
          .WithMany()
          .HasForeignKey(ri => ri.PaymentMethodId)
          .OnDelete(DeleteBehavior.NoAction);  // Set to null on delete

      modelBuilder.Entity<Sales>()
          .HasOne(ri => ri.Restaurant)
          .WithMany()
          .HasForeignKey(ri => ri.RestaurantId)
          .OnDelete(DeleteBehavior.NoAction);  // Set to null on delete

      // Supplier Inventory
      modelBuilder.Entity<SupplierInventories>()
          .HasOne(ri => ri.Supplier)
          .WithMany()
          .HasForeignKey(ri => ri.SupplierId)
          .OnDelete(DeleteBehavior.NoAction);  // Set to null on delete

      modelBuilder.Entity<SupplierInventories>()
          .HasOne(ri => ri.SupplierItems)
          .WithMany()
          .HasForeignKey(ri => ri.SupplierItemId)
          .OnDelete(DeleteBehavior.NoAction);  // Set to null on delete


      // Seed data
      new SeedInitializer(modelBuilder).Seed();


    }





  }
}
