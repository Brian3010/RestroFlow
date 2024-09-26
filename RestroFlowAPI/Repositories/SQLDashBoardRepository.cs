using Microsoft.EntityFrameworkCore;
using RestroFlowAPI.Data;
using RestroFlowAPI.DTOs.DashBoadDTOs;
using RestroFlowAPI.DTOs.DashBoardDTOs;
using RestroFlowAPI.Helpers;
using RestroFlowAPI.Models;
using RestroFlowAPI.Repositories.Interfaces;

namespace RestroFlowAPI.Repositories
{
  public class SQLDashBoardRepository : IDashBoardRepository
  {
    private readonly RestroFlowDbContext _dbContext;
    private readonly ILogger<SQLDashBoardRepository> _logger;

    public SQLDashBoardRepository(RestroFlowDbContext dbContext, ILogger<SQLDashBoardRepository> logger) {
      _dbContext = dbContext;
      _logger = logger;
    }

    public Task<BudgetAndSpendingDto> GetBudgetAndSpendingWeekly() {
      throw new NotImplementedException();
    }

    public Task<ExpensesSummaryDto> GetExpenseSummarybyLongPeriod(LongPeriod period) {
      throw new NotImplementedException();
    }

    public Task<ExpensesSummaryDto> GetExpenseSummarybyShortPeriod(ShortPeriod period) {
      throw new NotImplementedException();
    }

    public Task<List<OverallReviewsDto>> GetOverallReviews(LongPeriod period) {
      throw new NotImplementedException();
    }

    public Task<SalesSummaryDto> GetSalesSummaryByLongPeriod(LongPeriod period) {
      throw new NotImplementedException();
    }

    private decimal CalculateGrossProfit(List<Sales> salesData) {
      // Example: If gross profit is calculated as 70% of the revenue
      return salesData.Sum(s => s.TotalAmount) * 0.70m;

    }
    private decimal CalculateExpenses(List<Sales> salesData, ShortPeriod period) {
      // Example: Dummy expenses, replace with actual expense calculation logic
      return period == ShortPeriod.Daily ? 380.00m : 1200.00m;
    }
    public async Task<SalesSummaryDto> GetSalesSummaryByShortPeriod(ShortPeriod period = ShortPeriod.Daily) {
      _logger.LogInformation("period = {period}", period);

      //DateTime testStartDate = new DateTime(2024, 9, 16);
      //DateTime testEndDate = new DateTime(2024, 9, 18);
      //var SalesData = await _dbContext.Sales.Where(s => s.SaleDate >= testStartDate && s.SaleDate <= testEndDate).ToListAsync();

      var (startDate, endDate) = TimePeriodHelper.GetShortPeriodRange(period);
      _logger.LogInformation("startDate = {startDate}\n endData = {endDate}", startDate, endDate);

      var SalesData = await _dbContext.Sales.Where(s => s.SaleDate.Date >= startDate && s.SaleDate.Date <= endDate).OrderBy(s => s.SaleDate).ToListAsync();

      _logger.LogInformation("salesData = {@SalesData}", SalesData);

      // TODO: Calculate transactions by day and week
      int numberOfTransactions = SalesData.Count;

      // TODO: Calculate TotalSalesRevenue 
      decimal totalSalesRevenue = SalesData.Sum(s => s.TotalAmount);

      // TODO: Calculate GrossProfit
      decimal grossProfit = CalculateGrossProfit(SalesData);

      // TODO: Calculate NetProfit
      decimal expenses = CalculateExpenses(SalesData, period);
      decimal netProfit = grossProfit - expenses;

      // Best Selling Item (grouping by RestaurantMenuId to find the item with the highest quantity sold)
      var bestSellingItemData = SalesData
       .GroupBy(s => s.RestaurantMenuId)
       .Select(g => new {
         RestaurantMenuId = g.Key,
         QuantitySold = g.Sum(s => s.Quantity),
         TotalRevenue = g.Sum(s => s.TotalAmount),

       })
       .OrderByDescending(g => g.QuantitySold) // Sort by quantity sold to find the best seller
       .FirstOrDefault(); // Get the top-selling item

      // Fetch item details from RestaurantMenus if needed
      string bestSellingItemName = "";

      if (bestSellingItemData != null) {
        var bestSellingItem = await _dbContext.RestaurantMenus
            .Where(m => m.Id == bestSellingItemData.RestaurantMenuId)
            .FirstOrDefaultAsync();

        bestSellingItemName = bestSellingItem?.DishName ?? "Unknown";

      }
      // TODO: Calculate BestSellingItemQuantity
      var bestSellingItemQuantity = SalesData.OrderByDescending(s => s.Quantity).FirstOrDefault();


      // TODO: Calculate WorstSellingItem
      // TODO: Calculate WorstSellingItemQuantity




      throw new NotImplementedException();
    }
  }
}
