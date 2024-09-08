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
      _modelBuilder.Entity<Restaurant>().HasData(SeedData.RestaurantSeed);

      // RestaurantMenu table
      foreach (KeyValuePair<string, RestaurantMenu> item in SeedData.RestaurantMenuSeed) {
        _modelBuilder.Entity<RestaurantMenu>().HasData(item.Value);
      }

      //var restaurantMenus = SeedData.RestaurantMenus;
      //var test = restaurantMenus["Whole-Chicken"].Id;

      // Supplier table
      foreach (KeyValuePair<string, Supplier> item in SeedData.SupplierSeed) {
        _modelBuilder.Entity<Supplier>().HasData(item.Value);
      }

      // RestaurantItem table
      foreach (KeyValuePair<string, RestaurantItem> item in SeedData.RestaurantItemSeed) {
        _modelBuilder.Entity<RestaurantItem>().HasData(item.Value);
      }







    }

    //private void RestaurantSeed() {
    //  _modelBuilder.Entity<Restaurant>().HasData(SeedData.RestaurantSeed);
    //}
  }
}
