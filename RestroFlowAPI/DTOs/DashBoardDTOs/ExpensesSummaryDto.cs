namespace RestroFlowAPI.DTOs.DashBoardDTOs
{
  public class ExpensesSummaryDto
  {
    //public Guid? Id { get; set; } // Primary Key
    public DateTime ReportDate { get; set; }

    public required decimal TotalExpenses { get; set; }

    public required decimal LaborCosts { get; set; }

    public decimal Utilities { get; set; }

    public decimal? Rent { get; set; }

    public decimal? MiscellaneousExpenses { get; set; }
    public required string HighestExpenseCategory { get; set; }
    public required string LowestExpenseCategory { get; set; }

    public RestaurantDto Restaurant { get; set; }
  }
}
