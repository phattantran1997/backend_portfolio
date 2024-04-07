
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
        await _dbContext.Experiences.AddAsync(experience);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteExperienceAsync(int id)
    {
        var person = await _dbContext.Experiences.FindAsync(id);
        if (person != null)
        {
            _dbContext.Experiences.Remove(person);
            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Experience>> GetExperienceAsync()
    {
        return await _dbContext.Experiences.ToListAsync();
    }

    public async Task<Experience> GetExperienceByIdAsync(int id)
    {
        return await _dbContext.Experiences.FindAsync(id);

    }

    public async Task UpdateExperienceAsync(Experience experience)
    {
       _dbContext.Experiences.Update(experience);
        await _dbContext.SaveChangesAsync();
    }
}