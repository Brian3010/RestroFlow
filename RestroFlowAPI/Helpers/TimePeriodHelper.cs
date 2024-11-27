using RestroFlowAPI.Repositories.Interfaces;

namespace RestroFlowAPI.Helpers
{

  public class TimePeriodHelper
  {
    /// <summary>
    /// Get the start and end dates for the given <see cref="ShortPeriod"/> 
    /// </summary>
    /// <param name="period">The time period to calculate for</param>
    /// <returns>A tuple containing the start and end dates</returns>
    public static (DateTime StartDate, DateTime EndDate) GetShortPeriodRange(ShortPeriod period) {
      DateTime today = DateTime.Now.Date; // Get the current date without time
      //DateTime today = new DateTime(2024, 9, 26); // Get the current date without time
      DateTime startDate;
      DateTime endDate = today;

      switch (period) {
        case ShortPeriod.Daily:
          // Daily sales, today's date only
          startDate = today;
          endDate = today;
          break;

        case ShortPeriod.Weekly:
          // Weekly sales, calculate start of the week (Sunday) and end of the week (Saturday)
          int daysSinceSunday = (int)today.DayOfWeek; // Days passed since Sunday
          startDate = today.AddDays(-daysSinceSunday); // Start of the week (Sunday)
          endDate = startDate.AddDays(6); // End of the week (Saturday)
          break;


        default:
          throw new ArgumentException("Invalid time period specified.");
      }

      return (startDate, endDate);
    }


    /// <summary>
    /// Get the start and end dates for the given <see cref="LongPeriod"/> 
    /// </summary>
    /// <param name="period">The time period to calculate for</param>
    /// <returns>A tuple containing the start and end dates</returns>
    public static (DateTime StartDate, DateTime EndDate) GetLongPeriodRange(LongPeriod period) {
      DateTime today = DateTime.UtcNow.Date; // Get the current date without time
      DateTime startDate;
      DateTime endDate = today;

      switch (period) {

        case LongPeriod.Monthly:
          // Monthly sales, start from the first day of the current month
          startDate = new DateTime(today.Year, today.Month, 1); // First day of the month
          endDate = startDate.AddMonths(1).AddDays(-1); // Last day of the month
          break;

        case LongPeriod.Yearly:
          // Yearly sales, start from the first day of the current year
          startDate = new DateTime(today.Year, 1, 1); // January 1st
          endDate = new DateTime(today.Year, 12, 31); // December 31st
          break;


        default:
          throw new ArgumentException("Invalid time period specified.");
      }

      return (startDate, endDate);
    }





  }

}
