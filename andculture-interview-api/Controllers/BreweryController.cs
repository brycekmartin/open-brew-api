using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using andculture_interview_api.Models;
using andculture_interview_api.Services;
namespace andculture_interview_api.Controllers
{
    
    [ApiController]
    [Produces("application/json")]
    [Route("api")]
    public class BreweryController : ControllerBase
    {
        private readonly ILogger<BreweryController> _logger;
        private readonly IBreweryService _breweryService;
        public BreweryController(IBreweryService breweryService,ILogger<BreweryController> logger)
        {
            _logger = logger;
            _breweryService = breweryService;
        }
        [HttpGet("brewery")]
        public async Task<IActionResult> GetBreweries()
        {
            _logger.LogInformation("GetBreweries called.");

            try
            {
                var breweries = await _breweryService.GetBreweries();

                return Ok(breweries);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error getting breweries.");

                return BadRequest();
            }
        }
    }
}