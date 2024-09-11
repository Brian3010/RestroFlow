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
      //_modelBuilder.Entity<Restaurants>().HasData(SeedData.RestaurantSeed);

      //// RestaurantMenu table
      //foreach (KeyValuePair<string, RestaurantMenus> item in SeedData.RestaurantMenuSeed) {
      //  _modelBuilder.Entity<RestaurantMenus>().HasData(item.Value);
      //}

      ////var restaurantMenus = SeedData.RestaurantMenus;
      ////var test = restaurantMenus["Whole-Chicken"].Id;

      //// Supplier table
      //foreach (KeyValuePair<string, Suppliers> item in SeedData.SupplierSeed) {
      //  _modelBuilder.Entity<Suppliers>().HasData(item.Value);
      //}

      //// RestaurantItem table
      //foreach (KeyValuePair<string, RestaurantItems> item in SeedData.RestaurantItemSeed) {
      //  _modelBuilder.Entity<RestaurantItems>().HasData(item.Value);
      //}

      //// IncomeSource table
      //foreach (KeyValuePair<string, PaymentMethods> item in SeedData.PaymentMethodSeed) {
      //  _modelBuilder.Entity<PaymentMethods>().HasData(item.Value);
      //}

      // Sales Table 
      var SaleData = new List<Sales>();
      var paymentMethods = SeedData.PaymentMethodSeed.Values.ToList();
      var Dishes = SeedData.RestaurantMenuSeed.Values.ToList();

      for (int i = 0; i < 16; i++) {
        //Guid id = Guid.NewGuid();
        int paymentMethodsRandIdx = new Random().Next(paymentMethods.Count);
        int QuantityRandIdx = new Random().Next(SeedData.QuantitySeed.Count);
        //Console.WriteLine(id);
        SaleData.Add(new() {
          Id = Guid.NewGuid(),
          RestaurantId = SeedData.RestaurantSeed.Id,
          RestaurantMenuId = Dishes[i].Id,
          PaymentMethodId = paymentMethods[paymentMethodsRandIdx].Id,
          Quantity = SeedData.QuantitySeed[QuantityRandIdx],
          TotalAmount = Dishes[i].Price * SeedData.QuantitySeed[QuantityRandIdx],
          SaleDate = DateTime.Now.AddDays(-1),
        });
      }

      _modelBuilder.Entity<Sales>().HasData(SaleData);


    }
  }
}