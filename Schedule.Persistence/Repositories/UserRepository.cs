using Domain.Entities;
using Domain.Interfaces;
using Schedule.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Schedule.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context ) : base(context) { }

        public async Task<User> GetUserByType(UserType type) 
        {
            return await Context.users.FirstOrDefaultAsync(x => x.Type == type);
        }
    }
}