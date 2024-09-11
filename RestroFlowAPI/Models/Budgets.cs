using System.ComponentModel.DataAnnotations.Schema;

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

    public Guid Id { get; set; } // Primary Key

    [Column(TypeName = "decimal(18,2)")]
    public decimal BudgetAmount { get; set; }
    public string? Description { get; set; }
    // Weekly period represented by start and end dates
    public DateTime BudgetStartDate { get; set; }  // Start of the week
    public DateTime BudgetEndDate { get; set; }    // End of the week
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public BudgetCategories BudgetCategory { get; set; }

    // Foreign Key to Restaurants
    public Guid RestaurantId { get; set; }

    // Navigation Property
    public Restaurants Restaurant { get; set; }
  }
}
