using RestroFlowAPI.Data;
using RestroFlowAPI.DTOs.DashBoadDTOs;
using RestroFlowAPI.DTOs.DashBoardDTOs;
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

    public Task<SalesSummaryDto> GetSalesSummaryByShortPeriod(ShortPeriod period) {

      switch (period) {
        case ShortPeriod.Daily:
          // handle daily
          break;

        case ShortPeriod.Weekly:
          // handle weekly
          break;

      }



      throw new NotImplementedException();
    }
  }
}
