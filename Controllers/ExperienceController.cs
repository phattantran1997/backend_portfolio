using backend_portfolio;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ExperiencesController : ControllerBase{
    private readonly ILogger<ExperiencesController> _logger;
    private readonly IExperienceService _experienceService;

     public ExperiencesController(ILogger<ExperiencesController> logger, IExperienceService experienceService)
    {
        _logger = logger;
        _experienceService =experienceService;
    }
     [HttpGet]
    public async Task<IActionResult> GetExperience()
    {
        var Experience = await _experienceService.GetExperienceAsync();
        return Ok(Experience);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetExperience(int id)
    {
        var Experience = await _experienceService.GetExperienceByIdAsync(id);
        return Experience != null ? Ok(Experience) : NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> AddExperience(Experience experience)
    {
        await _experienceService.AddExperienceAsync(experience);
        return CreatedAtAction(nameof(GetExperience), new { id = experience.ID }, experience);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateExperience(int id, Experience experience)
    {
        if (id != experience.ID)
        {
            return BadRequest();
        }

        await _experienceService.UpdateExperienceAsync(experience);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteExperience(int id)
    {
        await _experienceService.DeleteExperienceAsync(id);
        return NoContent();
    }
}