using RestroFlowAPI.DTOs.DashBoardDTOs;
using RestroFlowAPI.Repositories.Interfaces;

namespace RestroFlowAPI.Repositories
{
  public class SQLDashBoardRepository : IDashBoardRepository
  {
    public Task<List<OverallReviewsDto>> GetOverallReviews(LongPeriod period) {
      throw new NotImplementedException();
    }

    public Task<SalesSummaryDto> GetSalesSummaryByLongPeriod(LongPeriod period) {
      throw new NotImplementedException();
    }

    public Task<SalesSummaryDto> GetSalesSummaryByShortPeriod(ShortPeriod period) {
      throw new NotImplementedException();
    }
  }
}
