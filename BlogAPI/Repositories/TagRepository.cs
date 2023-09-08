using BlogAPI.Models;
using BlogAPI.Repositories.Interfaces;

namespace BlogAPI.Repositories;

public class TagRepository : RepositoryBase<Tag, BlogContext>, ITagRepository
{
    public TagRepository(BlogContext context) : base(context)
    {
    }
}