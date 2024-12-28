namespace Schedule.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}
