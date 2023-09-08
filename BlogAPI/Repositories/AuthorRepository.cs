using BlogAPI.Models;
using BlogAPI.Repositories.Interfaces;

namespace BlogAPI.Repositories;

public class AuthorRepository : RepositoryBase<Author, BlogContext>, IAuthorRepository
{
    public AuthorRepository(BlogContext context) : base(context)
    {
    }
}