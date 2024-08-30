namespace RestroFlowAPI.Models
{
  public enum AlertTypes
  {
    OutOfStock,
    LowStock,
  }
  public class InventoryAlerts
  {
    public Guid AlertId { get; set; } // Primary Key
    public AlertTypes AlertType { get; set; }
    public float Threshold { get; set; } // alert if quantity <= threshhold 
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    // Foreign Key to RestaurantItems
    public Guid RestaurantItemId { get; set; }

    // Navigation Property
    public required RestaurantItems RestaurantItem { get; set; }
  }
}
