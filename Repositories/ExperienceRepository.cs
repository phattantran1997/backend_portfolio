
using Microsoft.EntityFrameworkCore;

public class ExperienceRepository : IExperienceRepository
{
    private readonly ApplicationDBContext _dbContext;
    public ExperienceRepository(ApplicationDBContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task AddExperienceAsync(Experience experience)
    {
        throw new NotImplementedException();
    }

    public Task DeleteExperienceAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Experience>> GetExperienceAsync()
    {
        return await _dbContext.Experiences.ToListAsync();
    }

    public Task<Experience> GetExperienceByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateExperienceAsync(Experience experience)
    {
        throw new NotImplementedException();
    }
}