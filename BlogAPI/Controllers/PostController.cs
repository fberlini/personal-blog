using BlogAPI.Models;
using BlogAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogAPI.Controllers;

[ApiController]
[Route("api/post")]
public class PostController : ControllerBase
{
    private readonly ILogger<PostController> _logger;
    private readonly IPostRepository _postRepository;

    public PostController(ILogger<PostController> logger, IPostRepository postRepository)
    {
        _logger = logger;
        _postRepository = postRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var posts = await _postRepository.GetAllAsync();

        if(posts == null || posts.Count == 0)
        {
            return Ok(new List<Post>());
        }

        return Ok(posts);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var post = await _postRepository.GetAsync(id);

        if(post == null)
        {
            return NotFound();
        }

        return Ok(post);
    }
}