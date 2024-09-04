namespace RestroFlowAPI.Models
{
  public class StockOrder
  {
    public required Guid Id { get; set; }

    public required int Quantity { get; set; }

    public required DateTime OrderDate { get; set; }
    public required DateTime CreatedAt { get; set; }
    public required DateTime UpdatedAt { get; set; }

    // Foreign Keys
    public Guid? SupplierId { get; set; }
    public Guid? RestaurantId { get; set; }
    public Guid? RestaurantItemId { get; set; }


    // Navigation Properties
    public Supplier? Supplier { get; set; }
    public RestaurantItem? RestaurantItem { get; set; }
    public Restaurant? Restaurant { get; set; }

  }
}
