using BlogAPI.Models;

namespace BlogAPI.Repositories;

public class SourceRepository : RepositoryBase<Source, BlogContext>, ISourceRepository
{
    public SourceRepository(BlogContext context) : base(context)
    {
    }
}