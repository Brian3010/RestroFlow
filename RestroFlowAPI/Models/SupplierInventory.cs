namespace RestroFlowAPI.Models
{
  public class SupplierInventory
  {
    public required Guid Id { get; set; }

    public required float Quantity { get; set; }
    public required string Unit { get; set; }

    public required DateTime LastUpdated { get; set; }

    // Foreign Keys
    public required Guid SupplierId { get; set; }
    public required Guid SupplierItemId { get; set; }

    // Navigation properties
    public required Supplier Supplier { get; set; }
    public required SupplierItem SupplierItems { get; set; }

  }
}
