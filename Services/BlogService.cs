using System.Net.Http.Headers;
using Newtonsoft.Json;

public class BlogService : IBlogService
{
    private readonly string _notionBlocksUrl = "https://api.notion.com/v1/blocks/289c3f117e02495ca6622818992424c8/children?page_size=100";
    private readonly string _notionPagesUrl = "https://api.notion.com/v1/pages/";
    // private readonly string _notionApiKey = "secret_LRzymn38n6i069CcKrBvq9MqurnzE3e3oYdJICZZRP4"; // Your Notion API key
    private readonly string _notionVersion = "2022-06-28"; // Notion API version
    private readonly IConfiguration _configuration;
    public BlogService(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public async Task<List<NotionBlog>> getNotionBlogsAsync()
    {
       try
    {            
        string notionApiKey = _configuration["NotionApi:ApiKey"];
        Console.WriteLine(notionApiKey);
        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", notionApiKey);
            client.DefaultRequestHeaders.Add("Notion-Version", _notionVersion);

            using (HttpResponseMessage response = await client.GetAsync(_notionBlocksUrl))
            {
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    Block blockListResponse = JsonConvert.DeserializeObject<Block>(responseBody);

                    List<string> blockIds = blockListResponse.Results.ConvertAll(block => block.Id);

                    List<NotionBlog> Blogs = new List<NotionBlog>();

                    foreach (string blockId in blockIds)
                    {
                        using (HttpResponseMessage pageResponse = await client.GetAsync($"{_notionPagesUrl}{blockId}"))
                        {
                            if (pageResponse.IsSuccessStatusCode)
                            {
                                var pageResponseBody = await pageResponse.Content.ReadAsStringAsync();
                                NotionBlog jsonData = JsonConvert.DeserializeObject<NotionBlog>(pageResponseBody);
                                Blogs.Add(jsonData);
                            }
                        }
                    }

                    return Blogs;
                }
                else
                {
                    throw new Exception($"Failed to fetch data from Notion API. Status code: {response.StatusCode}");
                }
            }
        }
    }
    catch (Exception ex)
    {
        throw new Exception($"Error fetching data from Notion API: {ex.Message}");
    }
    }
}