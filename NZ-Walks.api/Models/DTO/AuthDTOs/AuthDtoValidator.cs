using FluentValidation;

namespace NZ_Walks.api.Models.DTO.AuthDTOs
{
    public class AuthDtoValidator : AbstractValidator<RegisterAddRequest>
    {
        public AuthDtoValidator()
        {
            // Add validation rules here
            RuleFor(tmp => tmp.UserName)
                .NotEmpty()
                .WithMessage("User Name Cann't be Empty")
                .WithName("User Name")
                .EmailAddress()
                .WithMessage("Invalid Email Address")
                .MinimumLength(4)
                .WithMessage("User Name can't be less than 4 Characters");

            RuleFor(tmp => tmp.Password)
                .NotEmpty()
                .WithMessage("Password can't be Empty")
                .WithName("Password")
                .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$")
                .WithMessage("Password must contain at least one lowercase letter, one uppercase letter, one number, and one special character.")
                .MinimumLength(6)
                .WithMessage("Enter a valid password");
        }
    }
}
