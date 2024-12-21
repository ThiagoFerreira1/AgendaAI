using Domain.Entities;

namespace Domain.Interfaces
{
    public interface UserRepository : IBaseRepository<User>
    {
        Task<User> GetUserByType(UserType type);
    }
}