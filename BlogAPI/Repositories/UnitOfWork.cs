using BlogAPI.Repositories.Interfaces;

namespace BlogAPI.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private BlogContext _context;

    public UnitOfWork(BlogContext context)
    {
        _context = context;
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
