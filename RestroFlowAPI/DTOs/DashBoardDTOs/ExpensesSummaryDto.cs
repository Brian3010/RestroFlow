namespace RestroFlowAPI.DTOs.DashBoardDTOs
{
  public class ExpensesSummaryDto
  {
    public decimal TotalExpenses { get; set; }
    public required Dictionary<string, decimal> ExpenseByCategory { get; set; }
    //public decimal? MiscellaneousExpenses { get; set; }
    public required string HighestExpenseCategory { get; set; }
    public required decimal HighestExpenseCategoryCost { get; set; }
    public required string LowestExpenseCategory { get; set; }
    public required decimal LowestExpenseCategoryCost { get; set; }
    public DateTime? ReportDate { get; set; }
    public Guid? RestaurantId { get; set; }
  }
}
