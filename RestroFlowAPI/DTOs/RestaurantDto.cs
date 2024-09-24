namespace RestroFlowAPI.DTOs
{
  public class RestaurantDto
  {
    public required Guid Id { get; set; }

    public required string Name { get; set; }

    public required string Address { get; set; }

    public required string Suburb { get; set; }

    public required string City { get; set; }
  }
}
