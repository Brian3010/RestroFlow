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


    public async Task<ExpensesSummaryDto?> GetExpenseSummarybyShortPeriod(ShortPeriod period) {
      _logger.LogInformation("period = {period}", period);


      var (startDate, endDate) = TimePeriodHelper.GetShortPeriodRange(period);
      _logger.LogInformation("startDate = {startDate}\n endData = {endDate}", startDate, endDate);

      var expenseData = await _dbContext.Expenses.Where(e => e.ExpenseDate.Date >= startDate && e.ExpenseDate.Date <= endDate).OrderBy(e => e.ExpenseDate).ToListAsync();
      _logger.LogInformation("ExpenseData = {@ExpenseData}", expenseData);

      if (expenseData.Count == 0) return null;

      // Calculate TotalExpense
      var totalExpense = expenseData.Sum(e => e.Amount);

      // Calculate LaborCosts
      var laborCosts = expenseData.Where(e => e.ExpenseType == "Labour").Sum(e => e.Amount);

      // Calculate Utilities (Electricity, Internet and Water)
      var utilityTypes = new[] { "Electricity", "Internet", "Water" };
      var unilityCost = expenseData.Where(e => utilityTypes.Contains(e.ExpenseType))
        .Sum(e => e.Amount);

      // Calculate Rent
      var rentCost = expenseData
        .Where(e => e.ExpenseType == "Rent")
        .Sum(e => e.Amount);

      // TODO: Calculate MiscellaneousExpenses

      // Calculate HighestExpenseCategory except Rent and Labour
      var highestExpenseCategory = expenseData
        .Where(e => utilityTypes.Contains(e.ExpenseType))
        .OrderByDescending(e => e.Amount).FirstOrDefault();

      // TODO: trying to return an object that contain {Category and cost}
      var expenseUtilities = new List<Expenses>();
      foreach (var u in utilityTypes) {

      }


      _logger.LogInformation("testExpenseCosts = {@test}", expenses);



      // Calculate LowestExpenseCategory
      var lowestExpenseCategory = expenseData
        .Where(e => utilityTypes.Contains(e.ExpenseType))
        .OrderBy(e => e.Amount).FirstOrDefault();


      return new ExpensesSummaryDto {
        TotalExpenses = totalExpense,
        LaborCosts = laborCosts,
        Rent = rentCost,
        Utilities = unilityCost,
        HighestExpenseCategory = highestExpenseCategory!.ExpenseType,
        HighestExpenseCategoryCost = highestExpenseCategory!.Amount,
        LowestExpenseCategory = lowestExpenseCategory!.ExpenseType,
        LowestExpenseCategoryCost = lowestExpenseCategory!.Amount,
      };
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
    public async Task<SalesSummaryDto?> GetSalesSummaryByShortPeriod(ShortPeriod period = ShortPeriod.Daily) {
      _logger.LogInformation("period = {period}", period);

      //DateTime testStartDate = new DateTime(2024, 9, 26);
      //DateTime testEndDate = new DateTime(2024, 9, 26);
      //var SalesData = await _dbContext.Sales.Where(s => s.SaleDate.Date >= testStartDate && s.SaleDate.Date <= testEndDate).ToListAsync();

      var (startDate, endDate) = TimePeriodHelper.GetShortPeriodRange(period);
      _logger.LogInformation("startDate = {startDate}\n endData = {endDate}", startDate, endDate);

      var SalesData = await _dbContext.Sales.Where(s => s.SaleDate.Date >= startDate && s.SaleDate.Date <= endDate).OrderBy(s => s.SaleDate).ToListAsync();

      if (SalesData.Count == 0) return null;

      _logger.LogInformation("salesData = {@SalesData}", SalesData);

      // Calculate transactions by day and week
      int numberOfTransactions = SalesData.Count;

      // Calculate TotalSalesRevenue 
      decimal totalSalesRevenue = SalesData.Sum(s => s.TotalAmount);

      // Calculate GrossProfit
      decimal grossProfit = CalculateGrossProfit(SalesData);

      // Calculate NetProfit
      decimal expenses = CalculateExpenses(SalesData, period);
      decimal netProfit = grossProfit - expenses;

      // Calculate BestSellingItem and BestSellingItemQuantity
      var bestSellingItemData = SalesData
       .GroupBy(s => s.RestaurantMenuId)
       .Select(g => new {
         RestaurantMenuId = g.Key,
         QuantitySold = g.Sum(s => s.Quantity),
       }).OrderByDescending(s => s.QuantitySold).FirstOrDefault();

      //_logger.LogInformation("{bestSellingItemData}", bestSellingItemData);

      // Fetch item details from RestaurantMenus if needed
      string bestSellingItemName = "";
      int bestSellingItemNameQuantity = 0;
      if (bestSellingItemData != null) {
        var bestSellingItem = await _dbContext.RestaurantMenus
            .Where(m => m.Id == bestSellingItemData.RestaurantMenuId)
            .FirstOrDefaultAsync();

        bestSellingItemName = bestSellingItem?.DishName ?? "Unknown";
        bestSellingItemNameQuantity = bestSellingItemData.QuantitySold;
      }


      // Calculate WorstSellingItem and WorstSellingItemQuantity
      var worstSellingItemData = SalesData
       .GroupBy(s => s.RestaurantMenuId)
       .Select(g => new {
         RestaurantMenuId = g.Key,
         QuantitySold = g.Sum(s => s.Quantity),
       }).OrderBy(s => s.QuantitySold).FirstOrDefault();

      string worstSellingItemName = "";
      int worstSellingItemNameQuantity = 0;
      if (worstSellingItemData != null) {
        var worstSellingItem = await _dbContext.RestaurantMenus
            .Where(m => m.Id == worstSellingItemData.RestaurantMenuId)
            .FirstOrDefaultAsync();

        worstSellingItemName = worstSellingItem?.DishName ?? "Unknown";
        worstSellingItemNameQuantity = worstSellingItemData.QuantitySold;
      }


      return new SalesSummaryDto {
        NumberOfTransactions = numberOfTransactions,
        BestSellingItem = bestSellingItemName,
        BestSellingItemQuantity = bestSellingItemNameQuantity,
        WorstSellingItem = worstSellingItemName,
        WorstSellingItemQuantity = worstSellingItemNameQuantity,
        GrossProfit = grossProfit,
        NetProfit = netProfit,
        TotalSalesRevenue = totalSalesRevenue,
      };

    }
  }
}
