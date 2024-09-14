namespace RestroFlowAPI.Models
{
  public class StockOrders
  {
    public required Guid Id { get; set; }

    public required int Quantity { get; set; }

    public required DateTime OrderDate { get; set; }
    public required DateTime CreatedAt { get; set; }
    public required DateTime UpdatedAt { get; set; }

    // Foreign Keys
    public required Guid SupplierId { get; set; }
    public required Guid RestaurantItemId { get; set; }
    public required Guid RestaurantId { get; set; }

    // Navigation Properties
    public Suppliers? Supplier { get; set; }
    public RestaurantItems? RestaurantItem { get; set; }
    public Restaurants? Restaurant { get; set; }

  }
}
