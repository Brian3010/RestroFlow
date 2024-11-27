using System.ComponentModel.DataAnnotations.Schema;

namespace RestroFlowAPI.Models
{
  public class RestaurantItems
  {
    public required Guid Id { get; set; }

    public required string Name { get; set; }

    public required string Unit { get; set; }

    public string? Description { get; set; }

    //[Column(TypeName = "decimal(18,2)")]

    [Column(TypeName = "datetime2")]
    public required DateTime CreatedAt { get; set; }

    [Column(TypeName = "datetime2")]
    public required DateTime UpdatedAt { get; set; }

    // Foreign Keys
    public required Guid RestaurantId { get; set; }
    public required Guid SupplierId { get; set; }
    public required Guid ItemLocationId { get; set; } // back of house or front of house

    // Navigation properties
    public Restaurants Restaurant { get; set; }
    public Suppliers Supplier { get; set; }
    public ItemLocations ItemLocations { get; set; }

  }
}