using RestroFlowAPI.DTOs.DashBoardDTOs;
using RestroFlowAPI.Models;

namespace RestroFlowAPI.Repositories.Interfaces
{
  public enum TimePeriod
  {
    Daily,
    Weekly,
    Monthly,
    yearly
  }
  public interface IDashBoardRepository
  {
    // Total Revenue and Sales Summary
    Task<SalesSummaryDto> GetSalesSummaryByPeriod(TimePeriod period);

    // Top-Selling Products
    Task<Sales> GetTopSeliingProductByPeriod(TimePeriod period);

    // customer Satisfaction (Reviews)

    // Expenses Summary

    // Inventory Alerts (Low Stock)

    // Budget vs. Actual Spending
  }
}
