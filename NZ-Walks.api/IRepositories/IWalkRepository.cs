using NZ_Walks.api.Models.Domain;

namespace NZ_Walks.api.IRepositories
{
    public interface IWalkRepository
    {
        Task<Walk> CreateAsync(Walk walk);
        Task<Walk?> GetWalkAsync(Guid id);
        Task<List<Walk>> GetAllAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool? isAscending = null);
        Task<Walk?> UpdateAsync(Guid id, Walk walk);
        Task DeleteAsync(Guid id);
    }
}
