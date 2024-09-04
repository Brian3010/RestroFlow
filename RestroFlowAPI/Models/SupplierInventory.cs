namespace RestroFlowAPI.Models
{
  public class SupplierInventory
  {
    public required Guid Id { get; set; }

    public required float Quantity { get; set; }
    public required string Unit { get; set; }

    public required DateTime LastUpdated { get; set; }

    // Foreign Keys
    public Guid? SupplierId { get; set; }
    public Guid? SupplierItemId { get; set; }

    // Navigation properties
    public Supplier? Supplier { get; set; }
    public SupplierItem? SupplierItems { get; set; }

  }
}
