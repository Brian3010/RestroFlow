using System.ComponentModel.DataAnnotations.Schema;

namespace RestroFlowAPI.Models
{

  public class RestaurantMenu
  {
    public required Guid Id { get; set; }

    public required string DishName { get; set; }
    public required string Category { get; set; } // "Main Course", "Appetizer", "Dessert"

    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    public required string Description { get; set; }



    // foreign key
    public Guid RestaurantId { get; set; }

    // navigation properties
    public Restaurant Restaurant { get; set; }


  }
}
