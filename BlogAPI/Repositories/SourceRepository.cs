using BlogAPI.Models;
using BlogAPI.Repositories.Interfaces;

namespace BlogAPI.Repositories;

public class SourceRepository : RepositoryBase<Source, BlogContext>, ISourceRepository
{
    public SourceRepository(BlogContext context) : base(context)
    {
    }
}