using RestroFlowAPI.DTOs.DashBoardDTOs;

namespace RestroFlowAPI.Repositories.Interfaces
{


  public enum ShortPeriod
  {
    Daily,
    Weekly,
  }

  public enum LongPeriod
  {
    Monthly,
    Yearly
  }
  public interface IDashBoardRepository
  {


    /// <summary>
    /// Using "Reviews" table to calculate reviews weekly and yearly
    /// </summary>
    /// <param name="period">Weekly and yearly</param>
    /// <returns>a list of overall reviews <see cref="OverallReviewsDto"/> from different review sources</returns>
    Task<List<OverallReviewsDto>> GetOverallReviews(LongPeriod period);

    /// <summary>
    /// Using "Expenses" table to calulate expense summary
    /// </summary>
    /// <param name="period">daily and weekly period</param>
    /// <returns><see cref="ExpensesSummaryDto"/> </returns>
    Task<ExpensesSummaryDto?> GetExpenseSummarybyShortPeriod(ShortPeriod period);

    /// <summary>
    /// Using "ExpenseReports" table for displaying summary. Calculated from "Expenses" table
    /// </summary>
    /// <param name="period">Monthly and yearly</param>
    /// <returns><see cref="ExpensesSummaryDto"/> </returns>
    Task<ExpensesSummaryDto> GetExpenseSummarybyLongPeriod(LongPeriod period);


    /// <summary>
    /// Using "Budget" and "Expenses" tables
    /// </summary>
    /// <returns><see cref="BudgetAndSpendingDto"/></returns>
    Task<BudgetAndSpendingDto> GetBudgetAndSpendingWeekly();

    // Note: Can use Sales table to get specific week and month sale
  }
}
