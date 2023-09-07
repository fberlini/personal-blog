namespace BlogAPI.Models;

public class Post
{
    public Guid PostId { get; set; }
    public string Title { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? Content { get; set; }

    public ICollection<Author> Authors { get; set; }
    public ICollection<Source> Sources { get; set; }
    public ICollection<Tag> Tags{ get; set; }

    public Post()
    {
        this.PostId = Guid.NewGuid();
        this.Title = string.Empty;
        this.CreatedDate = DateTime.Now;
        this.Content = string.Empty;

        this.Authors = new List<Author>();
        this.Sources = new List<Source>();
        this.Tags = new List<Tag>();
    }
}