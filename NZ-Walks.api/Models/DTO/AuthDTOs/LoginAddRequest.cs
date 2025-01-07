using System.ComponentModel.DataAnnotations;

namespace NZ_Walks.api.Models.DTO.AuthDTOs
{
    public class LoginAddRequest
    {
        [DataType(DataType.EmailAddress,ErrorMessage = "invalid email address")]
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
