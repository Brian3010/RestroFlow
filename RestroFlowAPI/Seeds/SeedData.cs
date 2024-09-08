using RestroFlowAPI.Models;

namespace RestroFlowAPI.Seeds
{
  public class SeedData
  {
    public static readonly Restaurant RestaurantSeed = new Restaurant { Id = new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), Name = "Gami Chicken and Beer", Address = "840 Glenferrie Rd, Hawthorn VIC 3122", City = "Mebourne", Suburb = "Hawthorn", CreatedAt = new DateTime(2024, 1, 1, 14, 30, 0), UpdatedAt = new DateTime(2024, 1, 1, 14, 30, 0) };


    public static readonly Dictionary<string, Supplier> SupplierSeed = new() {
      {
        "B&E Food",
        new() {
          Id= new Guid("0a04327d-3b36-40ea-8759-f3d479e36529"), Name="B&E Food",Address="12 Oceanview Drive", City= "Bondi Beach", ContactEmail= "jane@befood.com", ContactName= "Jane Smith", ContactPhone= "03 9654 3210", CreatedAt = new DateTime(2024, 1, 1, 14, 30, 0), State = "VIC", UpdatedAt= new DateTime(2024, 1, 1, 14, 30, 0),
        }
      },

      {
        "Complete Food Services",
        new() {
          Id= new Guid("cf762d80-3731-4d9d-af92-b77f99676005"),Name="Complete Food Services",Address="45 Maple Street", City= "South Yarra", ContactEmail= "SarahJohnso@CFS.com", ContactName= "Sarah Johnso", ContactPhone= "07 3345 6721", CreatedAt = new DateTime(2024, 1, 1, 14, 30, 0), State = "VIC", UpdatedAt= new DateTime(2024, 1, 1, 14, 30, 0),
        }
      },

    };


    public static readonly Dictionary<string, RestaurantMenu> RestaurantMenuSeed = new() {
      {
        "The Classic Boneless", new (){Id= new Guid("9ca19c31-2e04-42e7-8cad-6e61bd177eaf"), Category="Fried Chicken (Boneless)", Description="Gami's most popular dish is back! Once again served on our signature wooden plate",DishName="The Classic Boneless",
      Price=42, RestaurantId=RestaurantSeed.Id }
      },

      {
        "Whole-Chicken", new (){Id= new Guid("4d165d8f-fbcf-4144-a318-374e7f08cb57"), Category="Fried Chicken (Bone-in)", Description="The traditional way to enjoy Korean chicken, a hands-on approach.",DishName="Whole-Chicken",
      Price=40, RestaurantId=RestaurantSeed.Id }
      },

      {
        "Regular Chicken", new (){Id= new Guid("1d74b052-3b59-465f-add2-d91f96b8961a"), Category="Fried Chicken (boneless)", Description="The cornerstone of Gami's authentic Korean taste.",DishName="Regular Chicken",
      Price=21, RestaurantId=RestaurantSeed.Id }
      }


  };


    public static readonly Dictionary<string, RestaurantItem> RestaurantItemSeed = new(){
      {"Whole chicken",
        new(){Id = new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"),Name="Whole chicken",Unit="Portion",SupplierId=SupplierSeed["B&E Food"].Id,CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now, RestaurantId = RestaurantSeed.Id }
      },

      {"Boneless chicken",
        new(){Id = new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"),Name="Boneless chicken",Unit="box",SupplierId= SupplierSeed["B&E Food"].Id,CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now, RestaurantId = RestaurantSeed.Id }
      },

      {"Chicken powder",
        new(){Id = new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"),Name="Chicken powder",Unit="bag",SupplierId=SupplierSeed["Complete Food Services"].Id,CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now, RestaurantId = RestaurantSeed.Id }
      },
    };

























  }
}
