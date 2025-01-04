using NZ_Walks.api.Models.Domain;

namespace NZ_Walks.api.Models.DTO.WalkDTOs
{
    public class WalkAddRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double LengthInKm { get; set; }
        public string? WalkImageUrl { get; set; }
        public Guid DifficultyId { get; set; }
        public Guid RegionId { get; set; }
    }
}
