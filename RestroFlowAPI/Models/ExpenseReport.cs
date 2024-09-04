namespace RestroFlowAPI.Models
{
  public class ExpenseReport
  {

    public Guid ReportId { get; set; } // Primary Key
    public DateTime ReportDate { get; set; }
    public decimal TotalExpenses { get; set; }
    public decimal LaborCosts { get; set; }
    public decimal Utilities { get; set; }
    public decimal Rent { get; set; }
    public decimal MiscellaneousExpenses { get; set; }
    public string HighestExpenseCategory { get; set; }
    public string LowestExpenseCategory { get; set; }
    public string ExpenseTimePeriod { get; set; }

    public Guid RestaurantId { get; set; } // Foreign Key to Restaurants

    // Navigation Property to Restaurant
    public Restaurant Restaurant { get; set; }
  }
}
