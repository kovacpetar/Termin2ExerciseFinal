using FluentValidation;
using TaskMngWebAPI.Models;

namespace TaskMngWebAPI.Validators
{
    public class AddUserValidator : AbstractValidator<AddUserRequest>
    {
        
        public AddUserValidator()
        {
            RuleFor(u => u.Password)
            .NotEmpty().WithMessage("Password is required.")
            .MinimumLength(8).WithMessage("Password must have at least 8 characters.")
            .Matches("[0-9]").WithMessage("Password must contain at least one number.")
            .Matches("[^a-zA-Z0-9]").WithMessage("Password must contain at least one special character.");
        }
    }
}
