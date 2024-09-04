using System.ComponentModel.DataAnnotations.Schema;

namespace RestroFlowAPI.Models
{
  public class Sale
  {
    public required Guid Id { get; set; }

    public required int Quantity { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public required decimal TotalAmount { get; set; }

    public required DateTime SaleDate { get; set; }

    // Foreign Keys
    public Guid? RestaurantId { get; set; }
    public Guid? RestaurantMenuId { get; set; }
    public Guid? IncomeSourceId { get; set; }



    // Navigation Properites
    public Restaurant? Restaurant { get; set; }
    public RestaurantMenu? RestaurantMenus { get; set; }
    public IncomeSource? IncomeSources { get; set; }

  }
}
