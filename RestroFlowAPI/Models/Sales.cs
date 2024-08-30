namespace RestroFlowAPI.Models
{
  public class Sales
  {
    public required Guid Id { get; set; }

    public required int Quantity { get; set; }

    public required decimal TotalAmount { get; set; }

    public required DateTime SaleDate { get; set; }

    // Foreign Keys
    public required Guid RestaurantId { get; set; }
    public required Guid RestaurantMenuId { get; set; }
    public required Guid IncomeSourceId { get; set; }



    // Navigation Properites
    public required Restaurant Restaurant { get; set; }
    public required RestaurantMenus RestaurantMenus { get; set; }
    public required IncomeSources IncomeSources { get; set; }

  }
}
