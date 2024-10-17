using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestroFlowAPI.Repositories.Interfaces;

namespace RestroFlowAPI.Controllers
{
  [Route("api/dashboard")]
  [ApiController]
  public class DashboardController : ControllerBase
  {
    private readonly IDashBoardRepository _dashBoardRepository;
    private readonly ILogger<DashboardController> _logger;

    public DashboardController(IDashBoardRepository dashBoardRepository, ILogger<DashboardController> logger) {
      _dashBoardRepository = dashBoardRepository;
      _logger = logger;
    }

    // GET: api/dashboard/expense-summary/short?period=
    [HttpGet("expense-summary")]
    [Authorize]
    public async Task<IActionResult> GetExpenseSummaryByShortPeriod([FromQuery] Periods period) {
      string requestedPeriod;
      switch (period) {
        case Periods.Daily:
          requestedPeriod = "Daily";
          break;
        case Periods.Monthly:
          requestedPeriod = "Monthly";
          break;

        case Periods.Weekly:
          requestedPeriod = "Weekly";
          break;

        case Periods.Yearly:
          requestedPeriod = "Yearly";
          break;

        default:
          throw new ArgumentException("Invalid time period specified.");
      }

      var expenseSummary = await _dashBoardRepository.GetExpenseSummarybyPeriods(period);

      if (expenseSummary == null) return NotFound();

      return Ok(new { ExpenseSummary = expenseSummary, Period = requestedPeriod });

    }



  }
}
