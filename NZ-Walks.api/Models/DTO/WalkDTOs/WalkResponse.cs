using NZ_Walks.api.Models.Domain;
using NZ_Walks.api.Models.DTO.DifficultyDTOs;
using NZ_Walks.api.Models.DTO.RegionDTOs;

namespace NZ_Walks.api.Models.DTO.WalkDTOs
{
    public class WalkResponse
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double LengthInKm { get; set; }
        public string? WalkImageUrl { get; set; }
        public Guid DifficultyId { get; set; }
        public Guid RegionId { get; set; }
        public DifficultyResponse Difficulty { get; set; }
        public RegionResponse Region { get; set; }
    }
}