using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestroFlowAPI.Repositories.Interfaces;

namespace RestroFlowAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DashboardController : ControllerBase
  {
    private readonly IDashBoardRepository _dashBoardRepository;
    private readonly ILogger<DashboardController> _logger;

    public DashboardController(IDashBoardRepository dashBoardRepository, ILogger<DashboardController> logger) {
      _dashBoardRepository = dashBoardRepository;
      _logger = logger;
    }

    // GET: api/dashboard/SaleSummarybyShortPeriod
    [HttpGet("SaleSummarybyShortPeriod")]
    [Authorize]
    public async Task<IActionResult> GetSaleSummaryByShortPeriod([FromQuery] ShortPeriod ShortPeriod) {

      var saleSummary = await _dashBoardRepository.GetSalesSummaryByShortPeriod(ShortPeriod);

      if (saleSummary == null) return NotFound();

      return Ok(new { SaleSummary = saleSummary, Period = ShortPeriod == 0 ? "Daily" : "Weekly" });
    }

    // GET: api/dashboard/ExpenseSummarybyShortPeriod
    [HttpGet("ExpenseSummarybyShortPeriod")]
    [Authorize]
    public async Task<IActionResult> GetExpenseSummaryByShortPeriod([FromQuery] ShortPeriod ShortPeriod) {

      var expenseSummary = await _dashBoardRepository.GetExpenseSummarybyShortPeriod(ShortPeriod);

      if (expenseSummary == null) return NotFound();

      return Ok(new { ExpenseSummary = expenseSummary, Period = ShortPeriod == 0 ? "Daily" : "Weekly" });

    }

  }
}
