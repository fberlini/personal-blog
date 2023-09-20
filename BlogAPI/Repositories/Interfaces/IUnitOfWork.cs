namespace BlogAPI.Repositories.Interfaces;

public interface IUnitOfWork
{
    Task SaveChangesAsync();
}