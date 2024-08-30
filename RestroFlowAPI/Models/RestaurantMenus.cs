namespace RestroFlowAPI.Models
{

  public class RestaurantMenus
  {
    public required Guid Id { get; set; }

    public required string DishName { get; set; }
    public required string Category { get; set; } // "Main Course", "Appetizer", "Dessert"
    public decimal Price { get; set; }

    public required string Description { get; set; }



    // foreign key
    public Guid RestaurantId { get; set; }

    // n


  }
}
