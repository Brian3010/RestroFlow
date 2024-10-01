using Microsoft.EntityFrameworkCore;
using RestroFlowAPI.Models;

namespace RestroFlowAPI.Seeds
{
  public class SeedInitializer
  {
    private readonly ModelBuilder _modelBuilder;

    public SeedInitializer(ModelBuilder modelBuilder) {
      _modelBuilder = modelBuilder;

    }

    public void Seed() {
      // Restaurant table
      _modelBuilder.Entity<Restaurants>().HasData(SeedData.RestaurantSeed);

      // Supplier table
      foreach (KeyValuePair<string, Suppliers> item in SeedData.SupplierSeed) {
        _modelBuilder.Entity<Suppliers>().HasData(item.Value);
      }

      // ItemLocations Table
      _modelBuilder.Entity<ItemLocations>().HasData(SeedData.ItemLocationsSeed);

      // RestaurantItem table
      foreach (KeyValuePair<string, RestaurantItems> item in SeedData.RestaurantItemSeed) {
        _modelBuilder.Entity<RestaurantItems>().HasData(item.Value);
      }

      //Expense Table
      _modelBuilder.Entity<Expenses>().HasData(SeedData.ExpensesSeed());

      //RestaurantInventory table
      _modelBuilder.Entity<RestaurantInventories>().HasData(SeedData.RestaurantInventoriesSeed());

      //InventoryAlerts table
      _modelBuilder.Entity<InventoryAlerts>().HasData(SeedData.InventoryAlertsSeed());

      // Budgets table 
      _modelBuilder.Entity<Budgets>().HasData(SeedData.BudgetSeed());

      // Reviews Table
      _modelBuilder.Entity<Reviews>().HasData(SeedData.ReviewSeed());

      // AlertRecipient table
      _modelBuilder.Entity<AlertRecipient>().HasData(SeedData.AlertRecipientsSeed);

      // StockOrders Table
      _modelBuilder.Entity<StockOrders>().HasData(SeedData.StockOrdersSeed());

      // SupplierItems table
      _modelBuilder.Entity<SupplierItems>().HasData(SeedData.SupplierItemsSeed());

      // BudgetExpenses table
      _modelBuilder.Entity<BudgetExpenses>().HasData(SeedData.BudgetExpensesSeed);


      // Supplierinventories table  added manually or another way ? 


    }
  }
}