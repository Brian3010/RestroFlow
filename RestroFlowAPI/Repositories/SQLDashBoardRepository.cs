using Microsoft.EntityFrameworkCore;
using RestroFlowAPI.Data;
using RestroFlowAPI.DTOs.DashBoardDTOs;
using RestroFlowAPI.Helpers;
using RestroFlowAPI.Repositories.Interfaces;


public class SQLDashBoardRepository : IDashBoardRepository
{
  private readonly RestroFlowDbContext _dbContext;
  private readonly ILogger<SQLDashBoardRepository> _logger;

  public SQLDashBoardRepository(RestroFlowDbContext dbContext, ILogger<SQLDashBoardRepository> logger) {
    _dbContext = dbContext;
    _logger = logger;
  }

  // TODO: implement this
  public Task<BudgetAndSpendingDto> GetBudgetAndSpending() {
    //var weeklyPeriod = ShortPeriod.Weekly;
    //var (startDate, endDate) = TimePeriodHelper.GetShortPeriodRange(weeklyPeriod); //
    //_logger.LogInformation("startDate = {startDate}\n endData = {endDate}", startDate, endDate);

    //// Get expenses within a week

    //var laborCostWeekly =  


    throw new NotImplementedException();
  }

  public async Task<ExpensesSummaryDto?> GetExpenseSummarybyPeriods(Periods period) {
    _logger.LogInformation("period = {period}", period);

    var (startDate, endDate) = TimePeriodHelper.GetPeriodRange(period);
    _logger.LogInformation("startDate = {startDate}\n endData = {endDate}", startDate, endDate);

    var expenseData = await _dbContext.Expenses.Where(e => e.ExpenseDate.Date >= startDate && e.ExpenseDate.Date <= endDate).OrderBy(e => e.ExpenseDate).ToListAsync();
    _logger.LogInformation("ExpenseData = {@ExpenseData}", expenseData);

    if (expenseData == null || expenseData.Count == 0) return null;

    // Calculate Total Expenses
    decimal totalExpenses = expenseData.Sum(e => e.Amount); // ?? Check this by runing this 

    // Calculate Expense by Category (Dictionary)
    var expenseTypes = await _dbContext.BudgetExpenses.ToListAsync();

    var categoryExpenses = expenseData.Join(expenseTypes, // joint table
          expenseData => expenseData.ExpenseTypeId, // foreign key from expenseData
          expenseTypes => expenseTypes.Id, // primary key from expenseTypes
          (expenseData, expenseTypes) => new { expenseData.Amount, expenseTypes.Name }) // Join result
    .GroupBy(exp => exp.Name) // Group by ExpenseName
    .Select(group => new {
      ExpenseName = group.Key,
      TotalAmount = group.Sum(exp => exp.Amount)
    }).OrderBy(e => e.TotalAmount);
    _logger.LogInformation("categoryExpenses = {@categoryExpenses}", categoryExpenses);

    var expenseByCategory = categoryExpenses.ToDictionary(
      categoryExpense => categoryExpense.ExpenseName,
      categoryExpense => categoryExpense.TotalAmount
      );


    return new ExpensesSummaryDto() {
      TotalExpenses = totalExpenses,
      ExpenseByCategory = expenseByCategory,
    };

    //throw new NotImplementedException();


  }

  public Task<OverallReviewsDto?> GetOverallReviewsInMonth() {
    throw new NotImplementedException();
  }

}
