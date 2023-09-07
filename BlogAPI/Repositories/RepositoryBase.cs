using Microsoft.EntityFrameworkCore;

namespace BlogAPI.Repositories;

public abstract class RepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity>
        where TEntity : class
        where TContext : DbContext
{
    private readonly TContext _context;

    public RepositoryBase(TContext context)
    {
        this._context = context;
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        await this._context.Set<TEntity>().AddAsync(entity);
        await this._context.SaveChangesAsync();
        return entity;
    }

    public async Task<TEntity> DeleteAsync(int id)
    {
        var entity = await this._context.Set<TEntity>().FindAsync(id);
        if (entity == null)
        {
            return entity;
        }

        this._context.Set<TEntity>().Remove(entity);
        await this._context.SaveChangesAsync();

        return entity;
    }

    public async Task<TEntity> GetAsync(int id)
    {
        return await this._context.Set<TEntity>().FindAsync(id);
    }

    public async Task<List<TEntity>> GetAllAsync()
    {
        return await this._context.Set<TEntity>().ToListAsync();
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        this._context.Entry(entity).State = EntityState.Modified;
        await this._context.SaveChangesAsync();
        return entity;
    }
}