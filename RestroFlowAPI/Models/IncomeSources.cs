namespace RestroFlowAPI.Models
{

  public class IncomeSources
  {
    public required Guid Id { get; set; }

    public required string IncomeType { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
  }
}
