namespace RestroFlowAPI.Models
{
  public class IncomeSource
  {
    public required Guid Id { get; set; }

    public required string IncomeType { get; set; }

    public required DateTime CreatedAt { get; set; }
    public required DateTime UpdatedAt { get; set; }

  }
}