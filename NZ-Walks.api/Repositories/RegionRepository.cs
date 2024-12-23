using Microsoft.EntityFrameworkCore;
using NZ_Walks.api.Data;
using NZ_Walks.api.IRepositories;
using NZ_Walks.api.Models.Domain;

namespace NZ_Walks.api.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly ApplicationDbContext _db;

        public RegionRepository(ApplicationDbContext dbContext)
        {
            this._db = dbContext;
        }

        public async Task<Region> CreateRegionAsync(Region region)
        {
            await _db.Regions.AddAsync(region);
            await _db.SaveChangesAsync();
            return region;
        }

        /// <summary>
        /// Deleting region
        /// </summary>
        /// <param name="id">id of region to be deleted</param>
        /// <returns>NoContent</returns>
        public async Task DeleteRegionAsync(Guid id)
        {
            var region = _db.Regions.FirstOrDefault(tmp => tmp.Id == id);
            if(region != null)
            {
                _db.Regions.Remove(region);
                await _db.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Getting all regions
        /// </summary>
        /// <returns>list of regions from database</returns>
        public async Task<List<Region>> GetAllRegionsAsync()
        {
            return await _db.Regions.ToListAsync();
        }

        /// <summary>
        /// Getting region by id from database
        /// </summary>
        /// <param name="id">region id</param>
        /// <returns>region from database</returns>
        public async Task<Region?> GetRegionAsync(Guid id)
        {
            return await _db.Regions.FirstOrDefaultAsync(tmp => tmp.Id == id);
        }

        /// <summary>
        /// Updating region
        /// </summary>
        /// <param name="id">id of region to be updated</param>
        /// <param name="region">the region to be updated</param>
        /// <returns></returns>
        public async Task<Region?> UpdateRegionAsync(Guid id, Region region)
        {
            var regionFromDb = await _db.Regions.FirstOrDefaultAsync(tmp => tmp.Id == id);
            if(regionFromDb != null)
            {
                regionFromDb.Code = region.Code;
                regionFromDb.Name = region.Name;
                regionFromDb.RegionImageUrl = region.RegionImageUrl;
                await _db.SaveChangesAsync();
                return regionFromDb;
            }
            return null;
        }
    }
}
