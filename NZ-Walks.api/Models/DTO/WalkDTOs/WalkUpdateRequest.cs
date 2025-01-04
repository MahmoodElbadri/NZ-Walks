using System.ComponentModel.DataAnnotations;

namespace NZ_Walks.api.Models.DTO.WalkDTOs
{
    public class WalkUpdateRequest
    {
        [Required]
        [MaxLength(100, ErrorMessage = "Name is too long")]
        [MinLength(3, ErrorMessage = "Name is too short")]
        public string? Name { get; set; }
        [Required]
        [StringLength(1000, MinimumLength = 3, ErrorMessage = "Description must be between 3 and 1000 characters")]
        public string? Description { get; set; }
        public double LengthInKm { get; set; }
        public string? WalkImageUrl { get; set; }
        [Required]
        public Guid DifficultyId { get; set; }
        [Required]
        public Guid RegionId { get; set; }
    }
}