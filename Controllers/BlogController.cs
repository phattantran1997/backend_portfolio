using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class BlogController : ControllerBase
{
    private readonly IBlogService _blogService;
    public BlogController(IBlogService blogService)
    {
        _blogService = blogService;
    }
        [HttpGet("notion")]
        public async Task<IActionResult> GetDataFromNotion()
        {
            try
            {
                List<NotionBlog> responseData = await _blogService.getNotionBlogsAsync();
                return Ok(responseData);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }
}