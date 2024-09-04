﻿namespace RestroFlowAPI.Models
{
  public enum AlertTypes
  {
    OutOfStock,
    LowStock,
  }
  public class InventoryAlert
  {
    public Guid Id { get; set; } // Primary Key
    public AlertTypes AlertType { get; set; }
    public float Threshold { get; set; } // alert if quantity <= threshhold 
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    // Foreign Key to RestaurantItems
    public Guid RestaurantItemId { get; set; }

    // Navigation Property
    public required RestaurantItem RestaurantItem { get; set; }
  }
}
