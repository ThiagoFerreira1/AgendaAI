using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;
using Schedule.Domain.Interfaces;

namespace Schedule.Application.UseCases.CreateUser
{
    public class CreateUserHandler : IRequestHandler<CreateUserRequest, CreateUserResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public CreateUserHandler(IUnitOfWork unitOfWork, IUserRepository userRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<CreateUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request);

            _userRepository.Create(user);

            await _unitOfWork.Commit();

            return _mapper.Map<CreateUserResponse>(user);

        }
    }
}
