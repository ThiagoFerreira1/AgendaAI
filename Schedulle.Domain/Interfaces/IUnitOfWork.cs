namespace Schedule.Domain.Interfaces
{
    internal interface IUnitOfWork
    {
        Task commit();
    }
}
