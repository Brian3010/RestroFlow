namespace RestroFlowAPI.Models
{
  public class RestaurantInventory
  {
    public required Guid Id { get; set; }

    public required float Quantity { get; set; }
    public required string Unit { get; set; }
    public required DateTime LastUdpated { get; set; }

    // Foreign Keys
    public Guid? RestaurantId { get; set; }
    public Guid? RestaurantItemId { get; set; }
    public Guid? SupplierId { get; set; }

    // Navigation properties
    public Restaurant? Restaurant { get; set; }
    public RestaurantItem? RestaurantItem { get; set; }
    public Supplier? Supplier { get; set; }

  }
}
