using System.ComponentModel.DataAnnotations;

namespace NZ_Walks.api.Models.DTO.ImageDTOs
{
    public class ImageAddRequest
    {
        [Required]
        public IFormFile? File { get; set; }
        [Required]
        public string? FileName { get; set; }
        public string? FileDescription { get; set; }
    }
}
