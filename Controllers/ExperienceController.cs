using backend_portfolio;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ExperiencesController : ControllerBase{
    private readonly ILogger<ExperiencesController> _logger;
     public ExperiencesController(ILogger<ExperiencesController> logger)
    {
        _logger = logger;
    }
     [HttpGet("{id}")]
        public ActionResult<Experience> GetExperienceById(int id)
        {
           return null;
        }
    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
        })
        .ToArray();
    }

}