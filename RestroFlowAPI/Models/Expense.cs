using System.ComponentModel.DataAnnotations.Schema;

namespace RestroFlowAPI.Models
{
  public class Expense
  {
    public required Guid Id { get; set; }

    public required string ExpenseType { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public required decimal Amount { get; set; }
    public required DateTime ExpenseDate { get; set; }

    // Foreign Key  
    public required Guid RestaurantId { get; set; }

    // Navigation properties
    public required Restaurant Restaurant { get; set; }

  }
}
