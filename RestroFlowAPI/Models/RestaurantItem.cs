using System.ComponentModel.DataAnnotations.Schema;

namespace RestroFlowAPI.Models
{
  public class RestaurantItem
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

    // Navigation properties
    public Restaurant Restaurant { get; set; }
    public Supplier Supplier { get; set; }

  }
}