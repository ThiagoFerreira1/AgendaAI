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
            entity.Created_At = DateTime.Now;
            Context.Add(entity);
        }

        public void Delete(T entity)
        {
            entity.Deleted_At = DateTime.Now;
            Context.Remove(entity);
        }

        public async Task<T> get(Guid id)
        {
            return await Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<T>> GetAll()
        {
            return await Context.Set<T>().ToListAsync();
        }

        public void Update(T entity)
        {
           entity.Updated_At = DateTime.Now;
            Context.Update(entity);
        }
    }
}