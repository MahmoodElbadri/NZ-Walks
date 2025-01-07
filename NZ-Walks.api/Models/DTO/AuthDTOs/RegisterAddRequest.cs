using System.ComponentModel.DataAnnotations;

namespace NZ_Walks.api.Models.DTO.AuthDTOs
{
    public class RegisterAddRequest
    {
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string[] Roles {  get; set; }
    }
}
