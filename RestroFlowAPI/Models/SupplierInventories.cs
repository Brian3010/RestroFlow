namespace RestroFlowAPI.Models
{
  public class SupplierInventories
  {
    public required Guid Id { get; set; }

    public required float Quantity { get; set; }
    public required string Unit { get; set; }

    public required DateTime LastUpdated { get; set; }

    // Foreign Keys
    public required Guid SupplierId { get; set; }
    public required Guid SupplierItemId { get; set; }

    // Navigation properties
    public Suppliers? Supplier { get; set; }
    public SupplierItems? SupplierItems { get; set; }

  }
}
