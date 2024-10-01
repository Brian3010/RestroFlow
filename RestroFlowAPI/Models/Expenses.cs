using System.ComponentModel.DataAnnotations.Schema;

namespace RestroFlowAPI.Models
{
  public class Expenses
  {
    public required Guid Id { get; set; }


    [Column(TypeName = "decimal(18,2)")]
    public required decimal Amount { get; set; }
    public required DateTime ExpenseDate { get; set; }

    // Foreign Key  
    public required Guid ExpenseTypeId { get; set; }
    public required Guid RestaurantId { get; set; }

    // Navigation properties
    public Restaurants Restaurant { get; set; }
    public BudgetExpenses BudgetExpenses { get; set; }

  }
}
