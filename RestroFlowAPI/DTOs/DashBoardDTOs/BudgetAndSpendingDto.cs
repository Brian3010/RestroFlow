namespace RestroFlowAPI.DTOs.DashBoardDTOs
{
  public class BudgetAndSpendingDto
  {
    public decimal Budget { get; set; }
    public decimal ActualSpending { get; set; }

    public decimal Difference { get; set; }
  }
}
