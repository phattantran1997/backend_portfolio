using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PostController : ControllerBase
{
    private readonly IPostService _postService;
    public PostController(IPostService postService)
    {
        _postService = postService;
    }
        [HttpGet]
        public async Task<IActionResult> GetDataFromNotion()
        {
            try
            {
                List<NotionPost> responseData = await _postService.getNotionPostsAsync();
                return Ok(responseData);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }
}