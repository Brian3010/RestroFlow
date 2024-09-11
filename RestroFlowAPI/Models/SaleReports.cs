using System.ComponentModel.DataAnnotations.Schema;

namespace RestroFlowAPI.Models
{

  public class SaleReports
  {
    public required Guid Id { get; set; }

    public Guid ReportId { get; set; } // Primary Key
    public int NumberOfTransactions { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalSalesRevenue { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal GrossProfit { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal NetProfit { get; set; }

    public required string BestSellingItem { get; set; }
    public int BestSellingItemQuantity { get; set; }
    public required string WorstSellingItem { get; set; }
    public int WorstSellingItemQuantity { get; set; }
    public required string SalesByCategory { get; set; } // JSON or VARCHAR(MAX)
    public required string SalesByPaymentMethod { get; set; } // JSON or VARCHAR(MAX)

    //public string SalesByTimePeriod { get; set; } // JSON or VARCHAR(MAX)
    public DateTime ReportDate { get; set; }

    // Foreign Key to Restaurants
    public Guid RestaurantId { get; set; }

    // Navigation properties
    public Restaurants restaurant { get; set; }
  }
}