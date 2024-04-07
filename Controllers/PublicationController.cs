using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PublicationsController : ControllerBase
{
    private readonly IPublicationService _publicationService;

    public PublicationsController(IPublicationService publicationService)
    {
        _publicationService = publicationService;
    }

    [HttpGet]
    public async Task<IActionResult> GetPublications()
    {
        var publications = await _publicationService.GetPublicationsAsync();
        return Ok(publications);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPublication(int id)
    {
        var publication = await _publicationService.GetPublicationByIdAsync(id);
        return publication != null ? Ok(publication) : NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> AddPublication(Publication publication)
    {
        await _publicationService.AddPublicationAsync(publication);
        return CreatedAtAction(nameof(GetPublication), new { id = publication.ID }, publication);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdatePublication(int id, Publication publication)
    {
        if (id != publication.ID)
        {
            return BadRequest();
        }

        await _publicationService.UpdatePublicationAsync(publication);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePublication(int id)
    {
        await _publicationService.DeletePublicationAsync(id);
        return NoContent();
    }
}