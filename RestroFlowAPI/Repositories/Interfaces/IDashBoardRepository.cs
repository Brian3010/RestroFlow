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
    /// Using "Sales" table to calculate sales summary
    /// </summary>
    /// <param name="period">the daily and weekly period</param>
    /// <returns>The sale summary defined by <see cref="SalesSummaryDto"/></returns>
    Task<SalesSummaryDto> GetSalesSummaryByShortPeriod(ShortPeriod period);

    /// <summary>
    /// Using "ReportSales" table to calculate sales summary. Calculated from "Sales" table
    /// </summary>
    /// <param name="period">the Monthly and yearly period</param>
    /// <returns>The sale summary defined by <see cref="SalesSummaryDto"/></returns>
    Task<SalesSummaryDto> GetSalesSummaryByLongPeriod(LongPeriod period);

    /// <summary>
    /// Using "Reviews" table to calculate reviews weekly and yearly
    /// </summary>
    /// <param name="period">Weekly and yearly</param>
    /// <returns>a list of overall reviews <see cref="OverallReviewsDto"/> from different review sources</returns>
    Task<List<OverallReviewsDto>> GetOverallReviews(LongPeriod period);

    // Expenses Summary

    // Inventory Alerts (Low Stock)

    // Budget vs. Actual Spending
  }
}
