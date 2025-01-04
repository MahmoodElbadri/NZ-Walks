using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NZ_Walks.api.Models.DTO.RegionDTOs
{
    public class RegionAddRequest
    {
        [Required]
        [DisplayName("Region Code")]
        [MaxLength(3,ErrorMessage = "{0} must be 3 characters")]
        [MinLength(3, ErrorMessage = "{0} must be 3 characters")]
        public string? Code { get; set; }
        [Required]
        [DisplayName("Region Name")]
        [Length(3, 20, ErrorMessage = "{0} must be between 3 and 20 characters")]
        public string? Name { get; set; }
        [DisplayName("Region Image Url")]
        public string? RegionImageUrl
        {
            get; set;
        }
    }
}
