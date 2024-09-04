namespace RestroFlowAPI.Models
{
  public enum ReviewResource
  {
    Google,
    Facebook,
    Instagram,
    Others
  }

  public class Review
  {

    public required Guid Id { get; set; }

    public ReviewResource ReviewSource { get; set; } = ReviewResource.Others;
    public string? ReviewContent { get; set; }
    public required DateTime ReviewDate { get; set; }
    public float? Rating { get; set; }

    // Foreign Keys
    public required Guid RestaurantId { get; set; }

    // Navigation Properties
    public required Restaurant Restaurant { get; set; }



  }
}
