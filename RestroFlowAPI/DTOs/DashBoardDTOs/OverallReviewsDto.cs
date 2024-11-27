namespace RestroFlowAPI.DTOs.DashBoardDTOs
{
  public class OverallReviewsDto
  {
    public required string ReviewSource { get; set; }
    public required string OverallReviewContent { get; set; }
    public float OverallRating { get; set; }

    public DateTime? ReviewDate { get; set; }
  }
}
