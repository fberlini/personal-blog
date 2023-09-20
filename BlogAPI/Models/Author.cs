namespace BlogAPI.Models;

public class Author
{
    public Guid AuthorId { get; set; }
    public required string FullName { get; set; }

    public ICollection<Post>? Posts { get; set; }
}