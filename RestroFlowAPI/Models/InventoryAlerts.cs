namespace RestroFlowAPI.Models
{
  //public enum AlertTypes
  //{
  //  OutOfStock,
  //  LowStock,
  //  SafetyStock
  //}
  public class InventoryAlerts
  {
    public Guid Id { get; set; } // Primary Key
    public required string AlertType { get; set; }
    public float Threshold { get; set; } // alert if quantity <= threshhold 
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    // Foreign Key to RestaurantItems
    public Guid RestaurantItemId { get; set; }

    // Navigation Property
    public RestaurantItems RestaurantItem { get; set; }
  }
}
