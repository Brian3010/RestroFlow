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

    // GET: api/dashboard/SaleSummary?ShortPeriod
    [HttpGet("SaleSummary")]
    [Authorize]
    public async Task<IActionResult> GetSaleSummaryByShortPeriod([FromQuery] ShortPeriod period) {
      var summary = await _dashBoardRepository.GetSalesSummaryByShortPeriod(period);
      // TODO: Fix this shit

      return Ok();
    }


  }
}
