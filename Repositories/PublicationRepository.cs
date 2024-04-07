
using Microsoft.EntityFrameworkCore;

public class PublicationRepository : IPublicationRepository
{
   private readonly ApplicationDBContext _dbContext;

    public PublicationRepository(ApplicationDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Publication>> GetPublicationsAsync()
    {
        return await _dbContext.Publications.ToListAsync();
    }

    public async Task<Publication> GetPublicationByIdAsync(int id)
    {
        return await _dbContext.Publications.FindAsync(id);
    }

    public async Task AddPublicationAsync(Publication publication)
    {
        await _dbContext.Publications.AddAsync(publication);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdatePublicationAsync(Publication publication)
    {
        _dbContext.Publications.Update(publication);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeletePublicationAsync(int id)
    {
        var publication = await _dbContext.Publications.FindAsync(id);
        if (publication != null)
        {
            _dbContext.Publications.Remove(publication);
            await _dbContext.SaveChangesAsync();
        }
    }
}