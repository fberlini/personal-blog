using BlogAPI.Models;
using BlogAPI.Repositories.Interfaces;

namespace BlogAPI.Repositories;

public class PostRepository : RepositoryBase<Post, BlogContext>, IPostRepository
{
    public PostRepository(BlogContext context) : base(context)
    {
    }
}