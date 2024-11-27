using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace RestroFlowAPI.Models
{
  public class ExpenseReports
  {

    public Guid Id { get; set; } // Primary Key
    public DateTime ReportDate { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalExpenses { get; set; }
    [Column(TypeName = "nvarchar(max)")]
    public string ExpenseByCategoryJson { get; set; } // Stores the JSON string

    [NotMapped] // This property will not be stored directly in the database
    public required Dictionary<string, decimal> ExpenseByCategory
    {
      get => JsonSerializer.Deserialize<Dictionary<string, decimal>>(ExpenseByCategoryJson);
      set => ExpenseByCategoryJson = JsonSerializer.Serialize(value);
    }


    //[Column(TypeName = "decimal(18,2)")]
    //public decimal LaborCosts { get; set; }

    //[Column(TypeName = "decimal(18,2)")]
    //public decimal Utilities { get; set; }

    //[Column(TypeName = "decimal(18,2)")]
    //public decimal Rent { get; set; }

    //[Column(TypeName = "decimal(18,2)")]
    //public decimal MiscellaneousExpenses { get; set; }
    //public string HighestExpenseCategory { get; set; }
    //public string LowestExpenseCategory { get; set; }

    public Guid RestaurantId { get; set; } // Foreign Key to Restaurants

    // Navigation Property to Restaurant
    public Restaurants Restaurant { get; set; }
  }
}
