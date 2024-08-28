namespace RestroFlowAPI.Models
{
  public class Supplier
  {
    public required Guid Id { get; set; }

    public required string ContactName { get; set; }

    public required string ContactEmail { get; set; }
    public required string ContactPhone { get; set; }
    public required string Address { get; set; }
    public required string City { get; set; }
    public required string State { get; set; }
    public required DateTime CreatedAt { get; set; }
    public required DateTime UpdatedAt { get; set; }

  }
}