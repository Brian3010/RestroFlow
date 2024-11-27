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
    [HttpGet("expense-summary/short")]
    [Authorize]
    public async Task<IActionResult> GetExpenseSummaryByShortPeriod([FromQuery] ShortPeriod period) {

      var expenseSummary = await _dashBoardRepository.GetExpenseSummarybyShortPeriod(period);

      if (expenseSummary == null) return NotFound();

      return Ok(new { ExpenseSummary = expenseSummary, Period = period == 0 ? "Daily" : "Weekly" });

    }

  }
}
