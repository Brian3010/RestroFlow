namespace RestroFlowAPI.DTOs.DashBoadDTOs
{
  public class SalesSummaryDto
  {
    //public Guid? Id { get; set; }
    public required int NumberOfTransactions { get; set; }

    public required decimal TotalSalesRevenue { get; set; }

    public required decimal GrossProfit { get; set; }

    public required decimal NetProfit { get; set; }

    public required string BestSellingItem { get; set; }
    public required int BestSellingItemQuantity { get; set; }
    public required string WorstSellingItem { get; set; }
    public required int WorstSellingItemQuantity { get; set; }

    public RestaurantDto Restaurant { get; set; }

  }
}
