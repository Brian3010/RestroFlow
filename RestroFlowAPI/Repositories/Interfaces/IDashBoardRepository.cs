using RestroFlowAPI.DTOs.DashBoardDTOs;

namespace RestroFlowAPI.Repositories.Interfaces
{


  public enum Periods
  {
    Daily,
    Weekly,
    Monthly,
    Yearly
  }

  //public enum LongPeriod
  //{
  //  Monthly,
  //  Yearly
  //}
  public interface IDashBoardRepository
  {
    // TODO: Review this again

    /// <summary>
    /// Using "Reviews" table to calculate reviews weekly and yearly
    /// </summary>
    /// <param name="period">Weekly and yearly</param>
    /// <returns>a list of overall reviews <see cref="OverallReviewsDto"/> from different review sources</returns>
    Task<OverallReviewsDto?> GetOverallReviewsInMonth();

    /// <summary>
    /// Using "Expenses" table to calulate expense summary
    /// </summary>
    /// <param name="period">daily and weekly, Monthly and yearly period</param>
    /// <returns><see cref="ExpensesSummaryDto"/> </returns>
    Task<ExpensesSummaryDto?> GetExpenseSummarybyPeriods(Periods period);



    /// <summary>
    /// Using "Budget" and "Expenses" tables
    /// </summary>
    /// <returns><see cref="BudgetAndSpendingDto"/></returns>
    Task<BudgetAndSpendingDto?> GetBudgetAndSpending();

    // Note: Can use Sales table to get specific week and month sale
  }
}
