using BlogAPI.Models;

namespace BlogAPI.Repositories.Interfaces;

public interface IPostRepository: IRepositoryBase<Post>
{
    Task<List<Post>> GetAllWithChildAsync();
}