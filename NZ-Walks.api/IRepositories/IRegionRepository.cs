using NZ_Walks.api.Models.Domain;

namespace NZ_Walks.api.IRepositories
{
    public interface IRegionRepository
    {
        Task <List<Region>> GetAllRegionsAsync();
        Task <Region?> GetRegionAsync(Guid id);
        Task <Region> CreateRegionAsync(Region region);
        Task <Region?> UpdateRegionAsync(Guid id, Region region);
        Task DeleteRegionAsync(Guid id);
    }
}
