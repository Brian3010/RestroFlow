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

      // RestaurantMenu table
      foreach (KeyValuePair<string, RestaurantMenus> item in SeedData.RestaurantMenuSeed) {
        _modelBuilder.Entity<RestaurantMenus>().HasData(item.Value);
      }

      //var restaurantMenus = SeedData.RestaurantMenus;
      //var test = restaurantMenus["Whole-Chicken"].Id;

      // Supplier table
      foreach (KeyValuePair<string, Suppliers> item in SeedData.SupplierSeed) {
        _modelBuilder.Entity<Suppliers>().HasData(item.Value);
      }

      // RestaurantItem table
      foreach (KeyValuePair<string, RestaurantItems> item in SeedData.RestaurantItemSeed) {
        _modelBuilder.Entity<RestaurantItems>().HasData(item.Value);
      }

      // IncomeSource table
      foreach (KeyValuePair<string, PaymentMethods> item in SeedData.PaymentMethodSeed) {
        _modelBuilder.Entity<PaymentMethods>().HasData(item.Value);
      }

      //Sales Table
      _modelBuilder.Entity<Sales>().HasData(SeedData.SaleSeed());

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

      // ItemLocations Table
      // AlertRecipient table
      // StockOrders Table
      // SupplierItems table 
    }
  }
}