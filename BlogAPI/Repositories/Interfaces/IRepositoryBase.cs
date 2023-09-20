namespace BlogAPI.Repositories.Interfaces;

public interface IRepositoryBase<T> where T : class
{
    Task<List<T>> GetAllAsync();
    Task<T?> GetAsync(Guid id);
    Task<T> AddAsync(T entity);
    T Update(T entity);
    Task<T?> DeleteAsync(Guid id);
}