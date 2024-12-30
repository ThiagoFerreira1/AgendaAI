using Core.Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Schedule.Persistence.Context;

namespace Schedule.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext Context;

        public BaseRepository(AppDbContext context)
        {
            Context = context;
        }

        public void Create(T entity)
        {
            entity.Created_At = DateTimeOffset.UtcNow;
            Context.Add(entity);
        }

        public void Delete(T entity)
        {
            entity.Deleted_At = DateTimeOffset.UtcNow;
            Context.Remove(entity);
        }

        public void Update(T entity)
        {
           entity.Updated_At = DateTimeOffset.UtcNow;
            Context.Update(entity);
        }

        public async Task<T> get(Guid id)
        {
            return await Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<T>> GetAll()
        {
            return await Context.Set<T>().ToListAsync();
        }
    }
}