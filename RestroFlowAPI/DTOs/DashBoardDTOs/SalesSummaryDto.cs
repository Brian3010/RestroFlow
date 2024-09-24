namespace RestroFlowAPI.DTOs.DashBoadDTOs
{
  public class SalesSummaryDto
  {
    public Guid? Id { get; set; }
    public int NumberOfTransactions { get; set; }

    public decimal TotalSalesRevenue { get; set; }

    public decimal GrossProfit { get; set; }

    public decimal NetProfit { get; set; }

    public required string BestSellingItem { get; set; }
    public int BestSellingItemQuantity { get; set; }
    public required string WorstSellingItem { get; set; }
    public int WorstSellingItemQuantity { get; set; }

    public RestaurantDto Restaurant { get; set; }

  }
}
