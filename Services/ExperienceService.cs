
public class ExperirenceService: IExperienceService{
    public readonly IExperienceRepository _repository;

    public ExperirenceService(IExperienceRepository repository)
    {
        _repository = repository;
    }
   public async Task<IEnumerable<Experience>> GetExperienceAsync()
    {
        return await _repository.GetExperienceAsync();
    }

    public async Task<Experience> GetExperienceByIdAsync(int id)
    {
        return await _repository.GetExperienceByIdAsync(id);
    }

    public async Task AddExperienceAsync(Experience experience)
    {
        await _repository.AddExperienceAsync(experience);
    }

    public async Task UpdateExperienceAsync(Experience experience)
    {
        await _repository.UpdateExperienceAsync(experience);
    }

    public async Task DeleteExperienceAsync(int id)
    {
        await _repository.DeleteExperienceAsync(id);
    }
}