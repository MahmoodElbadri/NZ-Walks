using Microsoft.EntityFrameworkCore;
using NZ_Walks.api.Data;
using NZ_Walks.api.IRepositories;
using NZ_Walks.api.Models.Domain;

namespace NZ_Walks.api.Repositories
{
    public class WalkRepository : IWalkRepository
    {
        private readonly ApplicationDbContext _db;

        public WalkRepository(ApplicationDbContext _db)
        {
            this._db = _db;
        }
        public async Task<Walk> CreateAsync(Walk walk)
        {
            await _db.Walks.AddAsync(walk);
            await _db.SaveChangesAsync();
            return walk;
        }

        public async Task DeleteAsync(Guid id)
        {
            var existingWalk = _db.Walks.FirstOrDefault(tmp=>tmp.Id == id);
            if (existingWalk == null)
            {
                throw new KeyNotFoundException($"Walk with id {id} not found.");
            }
            _db.Walks.Remove(existingWalk);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Walk>> GetAllAsync()
        {
            return await _db.Walks.Include(tmp=>tmp.Difficulty).Include(tmp=>tmp.Region).ToListAsync();
        }

        public async Task<Walk?> GetWalkAsync(Guid id)
        {
           var walk = await _db.Walks.Where(tmp => tmp.Id == id).FirstOrDefaultAsync();
            return walk;
        }

        public async Task<Walk?> UpdateAsync(Guid id, Walk walk)
        {
            var existingWalk = await _db.Walks.Where(tmp => tmp.Id == id).FirstOrDefaultAsync();
            if(existingWalk == null)
            {
                return null;
            }

            existingWalk.Name = walk.Name;
            existingWalk.Description = walk.Description;
            existingWalk.LengthInKm = walk.LengthInKm;
            existingWalk.RegionId = walk.RegionId;
            existingWalk.WalkImageUrl = walk.WalkImageUrl;
            existingWalk.DifficultyId = walk.DifficultyId;

            await _db.SaveChangesAsync();
            return existingWalk;
        }
    }
}
