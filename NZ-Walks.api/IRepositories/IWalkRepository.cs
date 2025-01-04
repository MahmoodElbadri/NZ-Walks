using NZ_Walks.api.Models.Domain;

namespace NZ_Walks.api.IRepositories
{
    public interface IWalkRepository
    {
        Task<Walk> CreateAsync(Walk walk);
        Task<Walk?> GetWalkAsync(Guid id);
        Task<List<Walk>> GetAllAsync();
        Task<Walk?> UpdateAsync(Guid id, Walk walk);
        Task DeleteAsync(Guid id);
    }
}
