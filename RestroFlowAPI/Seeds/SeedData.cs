using RestroFlowAPI.Models;

namespace RestroFlowAPI.Seeds
{
  public class SeedData
  {
    private static int NUMBER_OF_DATASET = 8;
    public SeedData() {

    }

    public static readonly Restaurants RestaurantSeed = new Restaurants { Id = new Guid("cc0db03e-f425-459f-88ca-26496d389dc1"), Name = "Gami Chicken and Beer", Address = "840 Glenferrie Rd, Hawthorn VIC 3122", City = "Mebourne", Suburb = "Hawthorn", CreatedAt = new DateTime(2024, 1, 1, 14, 30, 0), UpdatedAt = new DateTime(2024, 1, 1, 14, 30, 0) };


    public static readonly Dictionary<string, Suppliers> SupplierSeed = new() {
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

    public static readonly List<ItemLocations> ItemLocationsSeed = [
      new(){
        Id = Guid.NewGuid(),
        Name = "Back of House Stock Lists"
      },
      new(){
        Id = Guid.NewGuid(),
        Name = "Front of House Stock Lists"
      }
      ];

    public static readonly List<BudgetExpenses> BudgetExpensesSeed = [
      new (){
        Id =  Guid.Parse("d9b33212-dc51-4174-8e9d-299858f0ea88"),
        Name = "Labor",
        RestaurantId = Guid.Parse("cc0db03e-f425-459f-88ca-26496d389dc1")
        },
      new (){
        Id =  Guid.Parse("a57b3ede-7810-44d9-9f73-04dfa330a971"),
        Name = "Supplies",
        RestaurantId = Guid.Parse("cc0db03e-f425-459f-88ca-26496d389dc1")
        },

      ];


    public static readonly Dictionary<string, RestaurantItems> RestaurantItemSeed = new(){
      // B&E
      {"Whole chicken",
        new(){Id = new Guid("f58a9385-8a8b-43e7-a7ca-5a953a980cf4"),Name="Whole chicken",Unit="Portion",SupplierId=SupplierSeed["B&E Food"].Id,CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now, RestaurantId = RestaurantSeed.Id,ItemLocationId = ItemLocationsSeed[0].Id}
      },

      {"Boneless chicken",
        new(){Id = new Guid("122f8ddc-47dd-45e9-8bb5-6b1a3bd1949a"),Name="Boneless chicken",Unit="box",SupplierId= SupplierSeed["B&E Food"].Id,CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now, RestaurantId = RestaurantSeed.Id,ItemLocationId = ItemLocationsSeed[0].Id  }
      },

      {"Chicken wings",
        new(){Id = new Guid("116d32b5-4407-4fe4-9c6e-2aa38c8b6712"),Name="Chicken wings",Unit="container",SupplierId=SupplierSeed["B&E Food"].Id,CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now, RestaurantId = RestaurantSeed.Id,ItemLocationId = ItemLocationsSeed[0].Id }
      },

      {"Chicken steak",
        new(){Id = new Guid("f8472b62-e223-4033-8fb4-59a762cd0f12"),Name="Chicken Steak",Unit="container",SupplierId=SupplierSeed["B&E Food"].Id,CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now, RestaurantId = RestaurantSeed.Id,ItemLocationId = ItemLocationsSeed[0].Id }
      },

      {"Marinated beef",
        new(){Id = new Guid("973d9cfe-b929-4cf3-ab02-8dfeb1fa9442"),Name="Marinated beef",Unit="portion",SupplierId=SupplierSeed["B&E Food"].Id,CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now, RestaurantId = RestaurantSeed.Id,ItemLocationId = ItemLocationsSeed[0].Id }
      },

      // CFS 
      {"Chicken powder",
        new(){Id = new Guid("ea6d6784-afbe-4045-809d-90c3a972f12d"),Name="Chicken powder",Unit="bag",SupplierId=SupplierSeed["Complete Food Services"].Id,CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now, RestaurantId = RestaurantSeed.Id,ItemLocationId = ItemLocationsSeed[1].Id }
      },

      {"Soy garlic",
        new(){Id = new Guid("f87c819a-5b3a-4c09-bb42-b387790b70c0"),Name="Soy garlic",Unit="bag",SupplierId=SupplierSeed["Complete Food Services"].Id,CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now, RestaurantId = RestaurantSeed.Id,ItemLocationId = ItemLocationsSeed[1].Id  }
      },

      {"Spicy sauce",
        new(){Id = new Guid("51a801ff-89b7-4663-a308-b0b577018e14"),Name="Spicy sauce",Unit="bag",SupplierId=SupplierSeed["Complete Food Services"].Id,CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now, RestaurantId = RestaurantSeed.Id,ItemLocationId = ItemLocationsSeed[1].Id  }
      },


      {"Sweet Chiilies",
        new(){Id = new Guid("7a456054-4b0c-4005-8623-b4a7ecfb4103"),Name="Sweet Chiilies",Unit="bag",SupplierId=SupplierSeed["Complete Food Services"].Id,CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now, RestaurantId = RestaurantSeed.Id,ItemLocationId = ItemLocationsSeed[1].Id }
      },

      {"Wedges",
        new(){Id = new Guid("a50a5bdf-e0bb-41ae-b23d-87d5076265a7"),Name="Wedges",Unit="bag",SupplierId=SupplierSeed["Complete Food Services"].Id,CreatedAt = DateTime.Now, UpdatedAt= DateTime.Now, RestaurantId = RestaurantSeed.Id,ItemLocationId = ItemLocationsSeed[1].Id  }
      },


    };



    // Seeding Expenses, RestaurantInventory, InventoryAlerts, Budgets, Reviews


    // Expense Table for 10/11/12/9
    public static List<Expenses> ExpensesSeed() {
      decimal expenseRentAmount = 1500;
      List<decimal> expenseAmounts = [250, 100, 120, 80];
      string[] expenseTypes = ["a57b3ede-7810-44d9-9f73-04dfa330a971", "d9b33212-dc51-4174-8e9d-299858f0ea88"];
      int date = 1;
      int i = 0;
      List<Expenses> ExpenseData = [];

      while (i < expenseTypes.Length * NUMBER_OF_DATASET) {
        int inboundIdx = i % expenseTypes.Length;
        //Console.WriteLine(i);
        ExpenseData.Add(new() {
          Id = Guid.NewGuid(),
          RestaurantId = RestaurantSeed.Id,
          ExpenseTypeId = Guid.Parse(expenseTypes[inboundIdx]),
          Amount = expenseTypes[inboundIdx] == "Rent" ? expenseRentAmount : expenseAmounts[new Random().Next(expenseAmounts.Count)],
          ExpenseDate = inboundIdx == 0 ? DateTime.Now.AddDays(--date) : DateTime.Now.AddDays(date)
        });

        i++;
      }

      return ExpenseData;
    }

    // RestaurantInventory Table
    public static List<RestaurantInventories> RestaurantInventoriesSeed() {
      List<RestaurantInventories> restaurantInventoriesData = [];
      var restaurantItems = RestaurantItemSeed.Values.ToList();
      var suppliers = SupplierSeed.Values.ToList();
      List<int> quantities = [1, 4, 5, 6, 10, 22, 3, 9, 11, 12];
      int i = 0;
      int date = 1;
      while (i < restaurantItems.Count * NUMBER_OF_DATASET) {
        int inboundIdx1 = i % restaurantItems.Count;
        int inboundIdx2 = i % suppliers.Count;

        restaurantInventoriesData.Add(new() {
          Id = Guid.NewGuid(),
          RestaurantId = RestaurantSeed.Id,
          RestaurantItemId = restaurantItems[inboundIdx1].Id,
          SupplierId = suppliers[inboundIdx2].Id,
          Unit = restaurantItems[inboundIdx1].Unit,
          Quantity = quantities[new Random().Next(quantities.Count)],
          LastUdpated = inboundIdx1 == 0 ? DateTime.Now.AddDays(--date) : DateTime.Now.AddDays(date)

        });

        i++;
      }

      return restaurantInventoriesData;
    }

    // InventoryAlerts Table
    public static List<InventoryAlerts> InventoryAlertsSeed() {
      List<InventoryAlerts> inventoryAlertsData = [];
      List<int> threshHolds = [10, 8, 20, 9, 5, 3, 25];

      foreach (var item in RestaurantItemSeed) {
        inventoryAlertsData.Add(new() {
          Id = Guid.NewGuid(),
          RestaurantItemId = item.Value.Id,
          //AlertType = "Low Stock",
          Threshold = threshHolds[new Random().Next(threshHolds.Count)],
          CreatedAt = DateTime.Now,
          UpdatedAt = DateTime.Now,
        });
      }


      return inventoryAlertsData;
    }

    // Budget Table
    public static List<Budgets> BudgetSeed() {
      List<Budgets> budgetData = [];
      int[] amount = [2000, 1000, 400];
      string[] budgetCategories = ["a57b3ede-7810-44d9-9f73-04dfa330a971", "d9b33212-dc51-4174-8e9d-299858f0ea88"];


      for (int i = 0; i < 2; i++) {
        budgetData.Add(new() {
          Id = Guid.NewGuid(),
          RestaurantId = RestaurantSeed.Id,
          BudgetAmount = amount[i],
          BudgetCategoryId = Guid.Parse(budgetCategories[i]),
          BudgetStartDate = DateTime.Now.AddDays(-7),
          BudgetEndDate = DateTime.Now,
        });
      }

      return budgetData;
    }

    // Review Table 
    public static List<Reviews> ReviewSeed() {
      List<Reviews> reviewData = [];
      List<int> ratings = [3, 2, 4, 5];
      List<string> reviewSources = ["Facebook", "Google", "Instagram", "Others"];

      for (int i = 0; i < 10; i++) {
        reviewData.Add(new() {
          Id = Guid.NewGuid(),
          RestaurantId = RestaurantSeed.Id,
          ReviewSource = reviewSources[new Random().Next(reviewSources.Count)],
          ReviewDate = DateTime.Now,
          Rating = ratings[new Random().Next(ratings.Count)]
        });

      }

      return reviewData;
    }

    // AlertRecipient table
    public static List<AlertRecipient> AlertRecipientsSeed = [
      new() {
        AlertRecipientId = Guid.NewGuid(),
        RecipientId = Guid.Parse("21804e79-b2bb-4a6e-9418-3cab51e579ac"), // admin
      },
      new() {
        AlertRecipientId = Guid.NewGuid(),
        RecipientId = Guid.Parse("f2ba15e2-f1d3-43d1-bb84-6767253ebbe2"), // owner
      },
      new() {
        AlertRecipientId = Guid.NewGuid(),
        RecipientId = Guid.Parse("36c8f410-61d4-49fb-beb0-ff35e319614e"), // manager
      },
      new() {
        AlertRecipientId = Guid.NewGuid(),
        RecipientId = Guid.Parse("9125374f-e121-40f2-b42f-089529dd5fbd"), // manager
      },
      ];


    // StockOrders Table
    public static List<StockOrders> StockOrdersSeed() {
      List<StockOrders> stockOrdersdata = [];
      int date = 1;
      int i = 0;
      var items = RestaurantItemSeed.Values.ToList();

      while (i < items.Count * NUMBER_OF_DATASET) {
        int inboundIdx = i % items.Count;
        var dateTime = inboundIdx == 0 ? DateTime.Now.AddDays(--date) : DateTime.Now.AddDays(date);
        stockOrdersdata.Add(
          new() {
            Id = Guid.NewGuid(),
            RestaurantId = RestaurantSeed.Id,
            RestaurantItemId = items[inboundIdx].Id,
            SupplierId = items[inboundIdx].SupplierId,
            Quantity = new Random().Next(5),
            OrderDate = dateTime,
            CreatedAt = dateTime,
            UpdatedAt = dateTime,
          }
          );

        i++;
      }

      return stockOrdersdata;

    }


    // SupplierItems table 
    public static List<SupplierItems> SupplierItemsSeed() {
      string[][] BnEFoodItems = [["Whole chicken", "pack"], ["Boneless Chicken", "box"], ["Chicken wings", "container"], ["Chicken steak", "container"], ["Marinated beef", "portion"], ["Drumstick", "container"], ["Skewers", "container"], ["Boiled gochujang", "container"], ["Boxing wings", "portion"], ["Carrot rings", "pack"], ["Eggs", "dozen"],];

      string[][] CFSItems = [["Chicken powder", "bag"], ["Soy garlic", "bag"], ["Spicy sauce", "bag"], ["Sweet chillies", "bag"], ["Wedges", "bag"], ["Chips", "bag"], ["Shoestring chips", "bag"], ["Corn ribs", "pack"], ["Mustard", ""], ["Ketchup", "gallon"], ["Milk", "carton"], ["Mayonnaise", "bucket"], ["Sour cream", "tub"], ["Mozzarella cheese", "bag"], ["Burger bun", "bag"], ["Slider bun", "bag"], ["Red spicy mayo", "bag"], ["Gochujang sauce", "bag"], ["Tteokbokki sauce", "bag"], ["Crushed garlic", "bucket"], ["Salted butter", "pack"], ["Cheese sauce", "bag"], ["Potato flake", ""], ["Whole gain mustard", "tub"], ["Tomato Relish", "bottle"], ["Prawn mandu", "pack"], ["Prawn burger", "pack"], ["Japchae mandu", "pack"], ["Hotteok", "pack"], ["K-donut", "pack"]];

      string[][] FFIItems = [["Coleslaw", "bag"], ["White radish", "container"], ["Mix salad", "box"], ["Corn kernel", "bag"], ["Dried garlic", "container"]];

      string[][] GFIItems = [["Instant noodle", "pack"], ["Rice cake", "bag"], ["Frying mix", "bag"], ["Pancake mix", "bag"], ["Dumpling", "bag"], ["Corn syrup", "gallon"], ["Seasame oil", "can"], ["Beef dashida", "bag"], ["Kimchi", "container"], ["Thai sweet chilli", "gallon"], ["Potato noodle", "box"], ["Fish cake", "bag"], ["Soy sauce", "jerrycan"]];


      decimal[] prices = [30.9M, 20.5M, 19.9M, 30.2M, 10, 11, 13.5M, 17.5M, 50, 25, 21, 22, 34];

      var supplierItemsData = new List<SupplierItems>();
      int totalItems = BnEFoodItems.Length + CFSItems.Length + FFIItems.Length + GFIItems.Length;

      // Seed item for B&E supplier
      /*for (int i = 0; i < BnEFoodItems.Length; i++) {

        supplierItemsData.Add(
          new() {
            Id = Guid.NewGuid(),
            Name = BnEFoodItems[i][0],
            Unit = BnEFoodItems[i][1],
            SupplierId = SupplierSeed["B&E Food"].Id,
            Price = prices[new Random().Next(prices.Length)],
            CreateAt = DateTime.Now,
            UpdatedAt = DateTime.Now,
          }
          );
      }*/

      for (int i = 0; i < totalItems; i++) {

        // B&E
        if (i < BnEFoodItems.Length) {
          Guid id = Guid.NewGuid();

          supplierItemsData.Add(
          new() {
            Id = id,
            Name = BnEFoodItems[i][0],
            Unit = BnEFoodItems[i][1],
            SupplierId = SupplierSeed["B&E Food"].Id,
            Price = prices[new Random().Next(prices.Length)],
            CreateAt = DateTime.Now,
            UpdatedAt = DateTime.Now,
          }
          );
        }

        // CFS
        if (i < CFSItems.Length) {
          Guid id = Guid.NewGuid();

          supplierItemsData.Add(
          new() {
            Id = id,
            Name = CFSItems[i][0],
            Unit = CFSItems[i][1],
            SupplierId = SupplierSeed["Complete Food Services"].Id,
            Price = prices[new Random().Next(prices.Length)],
            CreateAt = DateTime.Now,
            UpdatedAt = DateTime.Now,
          }
          );
        }

        // FFI
        if (i < FFIItems.Length) {
          Guid id = Guid.NewGuid();

          supplierItemsData.Add(
          new() {
            Id = id,
            Name = FFIItems[i][0],
            Unit = FFIItems[i][1],
            SupplierId = SupplierSeed["Fresh Food Industries"].Id,
            Price = prices[new Random().Next(prices.Length)],
            CreateAt = DateTime.Now,
            UpdatedAt = DateTime.Now,
          }
          );
        }

        // GFI 
        if (i < GFIItems.Length) {
          Guid id = Guid.NewGuid();

          supplierItemsData.Add(
          new() {
            Id = id,
            Name = GFIItems[i][0],
            Unit = GFIItems[i][1],
            SupplierId = SupplierSeed["GFI Foods"].Id,
            Price = prices[new Random().Next(prices.Length)],
            CreateAt = DateTime.Now,
            UpdatedAt = DateTime.Now,
          }
          );

        }
      }

      return supplierItemsData;
    }





  }
}
