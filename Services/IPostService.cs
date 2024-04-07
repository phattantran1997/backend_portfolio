public interface IPostService {
    public Task<List<NotionPost>> getNotionPostsAsync();
}