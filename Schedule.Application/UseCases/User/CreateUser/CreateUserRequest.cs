using MediatR;

namespace Schedule.Application.UseCases.CreateUser
{
    public sealed record CreateUserRequest(string Email, string Name) : IRequest<CreateUserResponse>;
}
