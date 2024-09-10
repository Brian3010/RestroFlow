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
          Id= new Guid("cf762d80-3731-4d9d-af92-b77f99676005"),Name="Complete Food Services",Address="45 Maple Street", City= "South Yarra", ContactEmail= "SarahJohnso@CFS.com", ContactName= "Sarah Johnso", ContactPhone= "07 3345 6721", CreatedAt = DateTime.Now, State = "VIC", UpdatedAt= DateTime.Now,
        }
      },

      {
        "Fresh Food Industries",
        new() {
          Id= new Guid("114288a7-a300-42c6-8578-5f52df5ce147"),Name="Fresh Food Industries",Address="88 Kangaroo Court", City= " Brisbane", ContactEmail= " JamesCooper@FFI.com", ContactName= "James Cooper", ContactPhone= "08 9314 7890", CreatedAt = DateTime.Now, State = "VIC", UpdatedAt= DateTime.Now,
        }
      },

      {
        "GFI Foods",
        new() {
          Id= new Guid("72ddd782-e777-41fe-85b2-e88c189a88f5"),Name="GFI Foods",Address="23 Sunset Avenue", City= "Fremantle", ContactEmail= "OliviaMiller@GFIFood.com", ContactName= "Olivia Miller", ContactPhone= "03 6234 9087", CreatedAt =DateTime.Now, State = "VIC", UpdatedAt= DateTime.Now,
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
      },

      {
        "10 Wings", new (){Id= new Guid("45859bd4-b0bd-4491-8b1b-7c33a940df8a"), Category="Fried Chicken (boneless)", Description="A mix of chicken wingettes and drumettes.",DishName="10 Wings",
      Price=17, RestaurantId=RestaurantSeed.Id }
      },

      {
        "Beef Bulgogi", new (){Id= new Guid("19924c8f-32e0-4c3d-b425-995ed0ddca5a"), Category="Korean Classics", Description="Tender slices of marinated beef and ve ies stir-fried with sweet potato noodles in a sweet soy sauce, served with rice and a fresh green salad with Tangerine dressing.",DishName="Beef Bulgogi",
      Price=18.5M, RestaurantId=RestaurantSeed.Id }
      },

      {
        "Bibimbap", new (){Id= new Guid("d5d66b38-5140-485b-8575-f83d5fae6a5f"), Category="Korean Classics", Description="A healthy and delicious Korean rice dish showcasing flavourful vegetables, your preferred protein and a choice of sauce. Topped with a fried egg.",DishName="Korean Classics",
      Price=16, RestaurantId=RestaurantSeed.Id }
      },

      {
        "Tteok Bokki", new (){Id= new Guid("dd636f75-f510-47eb-bfc8-cf2613defdba"), Category="Korean Classics", Description="TA beloved Korean favourite, featuring stir-fried rice cakes, fish cakes, assorted vegetables, and noodles, all coated in a rich and spicy Korean chilli sauce.",DishName="Tteok Bokki",
      Price=14.5M, RestaurantId=RestaurantSeed.Id }
      },

      {
        "Gami Chips", new (){Id= new Guid("6dac4780-fbf3-41f4-8971-b7abdef83a86"), Category="Sides", Description="Locally grown cut potato strips coated in Gami signature batter.",DishName="Gami Chips",
      Price=6.9M, RestaurantId=RestaurantSeed.Id }
      },

      {
        "Prawn Mandu", new (){Id= new Guid("fc693bcd-807b-4506-a8fd-dc3e31905a81"), Category="Sides", Description="5 deep-fried premium handmade dumplings, filled with chunky prawn meat wrapped in thin crispy skin.",DishName="Prawn Mandu",
      Price=14.5M, RestaurantId=RestaurantSeed.Id }
      },


  };


    public static readonly Dictionary<string, RestaurantItem> RestaurantItemSeed = new(){
      // B&E
      {"Whole chicken",
        new(){Id = new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"),Name="Whole chicken",Unit="Portion",SupplierId=SupplierSeed["B&E Food"].Id,CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now, RestaurantId = RestaurantSeed.Id }
      },

      {"Boneless chicken",
        new(){Id = new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"),Name="Boneless chicken",Unit="box",SupplierId= SupplierSeed["B&E Food"].Id,CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now, RestaurantId = RestaurantSeed.Id }
      },

      {"Chicken wings",
        new(){Id = new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"),Name="Chicken wings",Unit="container",SupplierId=SupplierSeed["B&E Food"].Id,CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now, RestaurantId = RestaurantSeed.Id }
      },

      {"Chicken steak",
        new(){Id = new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"),Name="Chicken Steak",Unit="container",SupplierId=SupplierSeed["B&E Food"].Id,CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now, RestaurantId = RestaurantSeed.Id }
      },

      {"Marinated beef",
        new(){Id = new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"),Name="Marinated beef",Unit="portion",SupplierId=SupplierSeed["B&E Food"].Id,CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now, RestaurantId = RestaurantSeed.Id }
      },

      // CFS 
      {"Chicken powder",
        new(){Id = new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"),Name="Chicken powder",Unit="bag",SupplierId=SupplierSeed["Complete Food Services"].Id,CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now, RestaurantId = RestaurantSeed.Id }
      },

      {"Soy garlic",
        new(){Id = new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"),Name="Soy garlic",Unit="bag",SupplierId=SupplierSeed["Complete Food Services"].Id,CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now, RestaurantId = RestaurantSeed.Id }
      },

      {"Spicy sauce",
        new(){Id = new Guid("51a801ff-89b7-4663-a308-b0b577018e14"),Name="Spicy sauce",Unit="bag",SupplierId=SupplierSeed["Complete Food Services"].Id,CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now, RestaurantId = RestaurantSeed.Id }
      },


      {"Sweet Chiilies",
        new(){Id = new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"),Name="Sweet Chiilies",Unit="bag",SupplierId=SupplierSeed["Complete Food Services"].Id,CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now, RestaurantId = RestaurantSeed.Id }
      },

      {"Wedges",
        new(){Id = new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"),Name="Wedges",Unit="bag",SupplierId=SupplierSeed["Complete Food Services"].Id,CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now, RestaurantId = RestaurantSeed.Id }
      },


    };

    public readonly static Dictionary<string, IncomeSource> IncomeSourceSeed = new() {
      {"Dine-in",
        new() {
          Id = new Guid("a6995138-8ce2-4adb-9804-84b905125a7f"),IncomeType = "Dine-in", CreatedAt =DateTime.Now, UpdatedAt = DateTime.Now
        }
      },
      {"Delivery",
        new() {
          Id = new Guid("6eff914c-554b-47f2-b77f-a1b652f63337"),IncomeType = "Delivery", CreatedAt =DateTime.Now, UpdatedAt = DateTime.Now
        }
      },
      {"Take-away",
        new() {
          Id = new Guid("4fd74864-68d0-44c7-ae4d-548aef790aad"),IncomeType = "Take-away", CreatedAt =DateTime.Now, UpdatedAt = DateTime.Now
        }
      }

    };

























  }
}
