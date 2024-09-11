using System.ComponentModel.DataAnnotations.Schema;

namespace RestroFlowAPI.Models
{

  //public enum PaymentMethods
  //{
  //  Cash,
  //  CreditCard
  //}
  public class Sales
  {
    public required Guid Id { get; set; }

    public required int Quantity { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public required decimal TotalAmount { get; set; }

    //public required PaymentMethods PaymentMethod { get; set; }

    public required DateTime SaleDate { get; set; }

    // Foreign Keys
    public Guid? RestaurantId { get; set; }
    public Guid? RestaurantMenuId { get; set; }
    public Guid? PaymentMethodId { get; set; }



    // Navigation Properites
    public Restaurants? Restaurant { get; set; }
    public RestaurantMenus? RestaurantMenus { get; set; }
    public PaymentMethods? PaymentMethods { get; set; }

  }
}
