namespace BlogAPI.Models;

public class Post
{
    public Guid PostId { get; set; }
    public required string Title { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? Content { get; set; }

    public ICollection<Author>? Authors { get; set; }
    public ICollection<Source>? Sources { get; set; }
    public ICollection<Tag>? Tags{ get; set; }
}