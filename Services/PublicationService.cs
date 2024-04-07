public class PublicationService : IPublicationService
{
    private readonly IPublicationRepository _repository;

    public PublicationService(IPublicationRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Publication>> GetPublicationsAsync()
    {
        return await _repository.GetPublicationsAsync();
    }

    public async Task<Publication> GetPublicationByIdAsync(int id)
    {
        return await _repository.GetPublicationByIdAsync(id);
    }

    public async Task AddPublicationAsync(Publication publication)
    {
        await _repository.AddPublicationAsync(publication);
    }

    public async Task UpdatePublicationAsync(Publication publication)
    {
        await _repository.UpdatePublicationAsync(publication);
    }

    public async Task DeletePublicationAsync(int id)
    {
        await _repository.DeletePublicationAsync(id);
    }
}