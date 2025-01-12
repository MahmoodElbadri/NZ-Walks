using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace NZ_Walks.UI.Models.ViewModels
{
    public class AddRegionVM
    {
        [Required]
        [DisplayName("Region Code")]
        [StringLength(3, ErrorMessage = "{0} must be exactly 3 characters.")]
        public string? Code { get; set; }

        [Required]
        [DisplayName("Region Name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "{0} must be between 3 and 20 characters.")]
        public string? Name { get; set; }

        [DisplayName("Region Image URL")]
        public string? RegionImageUrl { get; set; }
    }
}


