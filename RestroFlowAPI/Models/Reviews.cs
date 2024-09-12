namespace RestroFlowAPI.Models
{
  //public enum ReviewResource
  //{
  //  Google,
  //  Facebook,
  //  Instagram,
  //  Others
  //}

  public class Reviews
  {

    public required Guid Id { get; set; }

    public required string ReviewSource { get; set; }
    public string? ReviewContent { get; set; }
    public required DateTime ReviewDate { get; set; }
    public float? Rating { get; set; }

    // Foreign Keys
    public required Guid RestaurantId { get; set; }

    // Navigation Properties
    public Restaurants Restaurant { get; set; }



  }
}
