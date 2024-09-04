namespace RestroFlowAPI.Models
{
  public class SupplierItem
  {
    public required Guid Id { get; set; }

    public required string Name { get; set; }
    public required string Description { get; set; }
    public required decimal Price { get; set; }
    public required DateTime CreateAt { get; set; }
    public required DateTime UpdatedAt { get; set; }

    // Foreign Keys
    public required Guid SupplierId { get; set; }

    // Navigation properties
    public required Supplier Supplier { get; set; }

  }
}
