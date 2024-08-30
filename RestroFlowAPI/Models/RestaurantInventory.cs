namespace RestroFlowAPI.Models
{
  public class RestaurantInventory
  {
    public required Guid Id { get; set; }

    public required float Quantity { get; set; }
    public required string Unit { get; set; }
    public required DateTime LastUdpated { get; set; }

    // Foreign Keys
    public Guid RestaurantId { get; set; }
    public Guid RestaurantItemId { get; set; }
    public Guid SupplierId { get; set; }

    // Navigation properties
    public required Restaurant Restaurant { get; set; }
    public required RestaurantItems RestaurantItem { get; set; }
    public required Supplier Supplier { get; set; }

  }
}
