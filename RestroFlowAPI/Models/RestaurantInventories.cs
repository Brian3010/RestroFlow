namespace RestroFlowAPI.Models
{
  public class RestaurantInventories
  {
    public required Guid Id { get; set; }

    public required float Quantity { get; set; }
    public required string Unit { get; set; }
    public required DateTime LastUdpated { get; set; }

    // Foreign Keys
    public required Guid RestaurantId { get; set; }
    public required Guid RestaurantItemId { get; set; }
    public required Guid SupplierId { get; set; }

    // Navigation properties
    public Restaurants Restaurant { get; set; }
    public RestaurantItems RestaurantItem { get; set; }
    public Suppliers Supplier { get; set; }

  }
}
