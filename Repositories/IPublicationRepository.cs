public interface IPublicationRepository{
    Task<IEnumerable<Publication>> GetPublicationsAsync();
    Task<Publication> GetPublicationByIdAsync(int id);
    Task AddPublicationAsync(Publication publication);
    Task UpdatePublicationAsync(Publication publication);
    Task DeletePublicationAsync(int id);
}