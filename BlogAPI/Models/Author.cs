namespace BlogAPI.Models;

public class Author
{
    public Guid AuthorId { get; set; }
    public string FullName { get; set; }

    public ICollection<Post> Posts { get; set; }

    public Author()
    {
        this.AuthorId = Guid.NewGuid();
        this.FullName = string.Empty;
        this.Posts = new List<Post>();
    }
}