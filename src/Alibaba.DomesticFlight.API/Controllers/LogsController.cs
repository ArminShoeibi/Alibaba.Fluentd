using Microsoft.AspNetCore.Mvc;

namespace Alibaba.DomesticFlight.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LogsController : ControllerBase
{
    private readonly ILogger<LogsController> _logger;

    public LogsController(ILogger<LogsController> logger)
    {
        _logger = logger;
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> Iterate(ushort numberOfIteration)
    {
        for (int i = 0; i < numberOfIteration; i++)
        {
            _logger.LogInformation("{i} {Now} آرمین", i, DateTimeOffset.Now);
            await Task.Delay(TimeSpan.FromSeconds(1));
        }
        return Ok();
    }

}
