namespace RestroFlowAPI.Models
{
  public class Restaurant
  {
    public required Guid Id { get; set; }

    public required string Name { get; set; }

    public required string Address { get; set; }

    public required string City { get; set; }

    public required DateTime CreatedAt { get; set; }
    public required DateTime UpdatedAt { get; set; }
  }
}
