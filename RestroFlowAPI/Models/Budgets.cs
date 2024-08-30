namespace RestroFlowAPI.Models
{
  public enum BudgetCategories
  {
    LabourCost,
    SupplierCost,
    OtherCost,
  }
  public class Budgets
  {

    public Guid BudgetId { get; set; } // Primary Key
    public decimal BudgetAmount { get; set; }
    public string? Description { get; set; }
    public required string BudgetTimePeriod { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public BudgetCategories BudgetCategory { get; set; }

    // Foreign Key to Restaurants
    public Guid RestaurantId { get; set; }

    // Navigation Property
    public Restaurant Restaurant { get; set; }
  }
}
