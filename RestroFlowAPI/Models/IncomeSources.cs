namespace RestroFlowAPI.Models
{
  public enum IncomeTypes
  {
    OnlineOrders,
    TakeAway,
    DineIn
  }
  public class IncomeSources
  {
    public required Guid Id { get; set; }

    public required IncomeTypes IncomeType { get; set; }
  }
}
