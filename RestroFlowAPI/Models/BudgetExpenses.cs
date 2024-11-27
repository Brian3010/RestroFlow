namespace RestroFlowAPI.Models
{
  public class BudgetExpenses
  {
    public required Guid Id { get; set; }
    public required string Name { get; set; }

    public Guid RestaurantId { get; set; }
    public Restaurants Restaurant { get; set; }
  }
}
