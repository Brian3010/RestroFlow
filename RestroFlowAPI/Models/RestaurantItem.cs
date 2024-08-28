namespace RestroFlowAPI.Models
{
  public class RestaurantItem
  {
    public required Guid Id { get; set; }

    public required string Name { get; set; }

    public required string Description { get; set; }

    public required decimal Price { get; set; }

    public required DateTime CreatedAt { get; set; }
    public required DateTime UpdatedAt { get; set; }

    // Foreign Keys
    public Guid RestaurantId { get; set; }

    // Navigation properties
    public required Restaurant Restaurant { get; set; }

  }
}