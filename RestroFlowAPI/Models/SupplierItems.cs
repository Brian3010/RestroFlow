using System.ComponentModel.DataAnnotations.Schema;

namespace RestroFlowAPI.Models
{
  public class SupplierItems
  {
    public required Guid Id { get; set; }

    public required string Name { get; set; }
    public string? Description { get; set; }
    public required string Unit { get; set; }


    [Column(TypeName = "decimal(18,2)")]
    public required decimal Price { get; set; }
    public required DateTime CreateAt { get; set; }
    public required DateTime UpdatedAt { get; set; }

    // Foreign Keys
    public required Guid SupplierId { get; set; }

    // Navigation properties
    public Suppliers Supplier { get; set; }

  }
}
