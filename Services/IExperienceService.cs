public interface IExperienceService
{
    Task<IEnumerable<Experience>> GetExperienceAsync();
    Task<Experience> GetExperienceByIdAsync(int id);
    Task AddExperienceAsync(Experience experience);
    Task UpdateExperienceAsync(Experience experience);
    Task DeleteExperienceAsync(int id);
}