using Schedule.Domain.Interfaces;
using Schedule.Persistence.Context;

namespace Schedule.Persistence.Repositories
{
    public class UnityOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnityOfWork(AppDbContext context) { 
            _context = context;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}
