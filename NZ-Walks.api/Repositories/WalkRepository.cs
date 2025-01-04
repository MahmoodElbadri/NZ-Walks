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
            var existingWalk = _db.Walks.FirstOrDefault(tmp => tmp.Id == id);
            if (existingWalk == null)
            {
                throw new KeyNotFoundException($"Walk with id {id} not found.");
            }
            _db.Walks.Remove(existingWalk);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Walk>> GetAllAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool? isAscending = null)
        {
            var walks = _db.Walks.Include(tmp => tmp.Difficulty).Include(tmp => tmp.Region).AsQueryable();

            // Apply filtering
            if (!string.IsNullOrWhiteSpace(filterOn) && !string.IsNullOrWhiteSpace(filterQuery))
            {
                filterQuery = filterQuery.ToLower(); // Convert to lowercase once for efficiency

                if (filterOn.Equals("Name", StringComparison.OrdinalIgnoreCase))
                {
                    // Use EF.Functions.Like for case-insensitive search
                    walks = walks.Where(tmp => EF.Functions.Like(tmp.Name.ToLower(), $"%{filterQuery}%"));
                }
                else if (filterOn.Equals("Description", StringComparison.OrdinalIgnoreCase))
                {
                    // Similarly for description
                    walks = walks.Where(tmp => EF.Functions.Like(tmp.Description.ToLower(), $"%{filterQuery}%"));
                }
            }

            // Apply sorting
            if (!string.IsNullOrEmpty(sortBy))
            {
                if (sortBy.Equals("Name", StringComparison.OrdinalIgnoreCase))
                {
                    walks = isAscending.GetValueOrDefault(true)
                        ? walks.OrderBy(tmp => tmp.Name)
                        : walks.OrderByDescending(tmp => tmp.Name);
                }
                else if (sortBy.Equals("Length", StringComparison.OrdinalIgnoreCase))
                {
                    walks = isAscending.GetValueOrDefault(true)
                        ? walks.OrderBy(tmp => tmp.LengthInKm)
                        : walks.OrderByDescending(tmp => tmp.LengthInKm);
                }
            }

            return await walks.ToListAsync();
        }

        public async Task<Walk?> GetWalkAsync(Guid id)
        {
            var walk = await _db.Walks.Where(tmp => tmp.Id == id).FirstOrDefaultAsync();
            return walk;
        }

        public async Task<Walk?> UpdateAsync(Guid id, Walk walk)
        {
            var existingWalk = await _db.Walks.Where(tmp => tmp.Id == id).FirstOrDefaultAsync();
            if (existingWalk == null)
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
