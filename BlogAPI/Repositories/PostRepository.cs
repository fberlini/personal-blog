using BlogAPI.Models;
using BlogAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlogAPI.Repositories;

public class PostRepository : RepositoryBase<Post, BlogContext>, IPostRepository
{
    public PostRepository(BlogContext context) : base(context)
    {
    }

    public Task<List<Post>> GetAllWithChildAsync()
    {
        return _context.Posts.Include(a => a.Authors).Include(s => s.Sources).Include(t => t.Tags).ToListAsync();
    }
}