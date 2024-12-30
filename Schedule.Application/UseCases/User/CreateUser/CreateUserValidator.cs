using FluentValidation;
using Schedule.Application.UseCases.CreateUser;

namespace Schedule.Application.UseCases.CreateUser
{
    public sealed class CreateUserValidator : AbstractValidator<CreateUserRequest>
    {
        public CreateUserValidator() 
        {
            RuleFor(x => x.Email).NotEmpty().MaximumLength(50).EmailAddress();
            RuleFor(x => x.Name).NotEmpty().MinimumLength(50).MaximumLength(50);
        }
    }
}
