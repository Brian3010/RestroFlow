using RestroFlowAPI.Data;
using RestroFlowAPI.DTOs.DashBoardDTOs;
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

  public Task<ExpensesSummaryDto?> GetExpenseSummarybyLongPeriod(LongPeriod period) {
    throw new NotImplementedException();
  }


  public async Task<ExpensesSummaryDto?> GetExpenseSummarybyShortPeriod(ShortPeriod period) {
    _logger.LogInformation("period = {period}", period);

    /*
    var (startDate, endDate) = TimePeriodHelper.GetShortPeriodRange(period);
    _logger.LogInformation("startDate = {startDate}\n endData = {endDate}", startDate, endDate);

    var expenseData = await _dbContext.Expenses.Where(e => e.ExpenseDate.Date >= startDate && e.ExpenseDate.Date <= endDate).OrderBy(e => e.ExpenseDate).ToListAsync();
    _logger.LogInformation("ExpenseData = {@ExpenseData}", expenseData);

    if (expenseData.Count == 0) return null;

    // Calculate TotalExpense
    var totalExpense = expenseData.Sum(e => e.Amount);

    // Calculate LaborCosts
    var laborCosts = expenseData.Where(e => e.ExpenseType == "Labour").Sum(e => e.Amount);

    // Calculate Rent
    var rentCost = expenseData
      .Where(e => e.ExpenseType == "Rent")
      .Sum(e => e.Amount);

    // TODO: Calculate MiscellaneousExpenses

    // Calculate Utilities (Electricity, Internet and Water)
    var utilityTypes = new[] { "Electricity", "Internet", "Water" };
    var utilityExpenses = expenseData.Where(e => utilityTypes.Contains(e.ExpenseType));

    var unilityCost = utilityExpenses.Sum(expense => expense.Amount);

    // Calculate Utitlties Expenses
    var GroupUtilExpenses = utilityExpenses
      .GroupBy(e => e.ExpenseType)
      .Select(g => new {
        Category = g.Key,
        TotalExpense = g.Sum(e => e.Amount)
      });

    var highestExpense = GroupUtilExpenses.OrderByDescending(e => e.TotalExpense).FirstOrDefault();

    var lowestExpense = GroupUtilExpenses.OrderBy(e => e.TotalExpense).FirstOrDefault();

    return new ExpensesSummaryDto {
      TotalExpenses = totalExpense,
      LaborCosts = laborCosts,
      Rent = rentCost,
      Utilities = unilityCost,
      HighestExpenseCategory = highestExpense.Category,
      HighestExpenseCategoryCost = highestExpense.TotalExpense,
      LowestExpenseCategory = lowestExpense.Category,
      LowestExpenseCategoryCost = lowestExpense.TotalExpense,
    };*/
    throw new NotImplementedException();
  }

  public Task<OverallReviewsDto?> GetOverallReviewsInMonth() {
    throw new NotImplementedException();
  }

}
