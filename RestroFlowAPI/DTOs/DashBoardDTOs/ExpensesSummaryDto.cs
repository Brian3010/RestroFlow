using System.ComponentModel.DataAnnotations.Schema;

namespace RestroFlowAPI.DTOs.DashBoardDTOs
{
  public class ExpensesSummaryDto
  {
    public Guid? Id { get; set; } // Primary Key
    public DateTime ReportDate { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalExpenses { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal LaborCosts { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal? Utilities { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal? Rent { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal? MiscellaneousExpenses { get; set; }
    public string? HighestExpenseCategory { get; set; }
    public string? LowestExpenseCategory { get; set; }

    // Navigation Property to Restaurant
    public RestaurantDto Restaurant { get; set; }
  }
}
