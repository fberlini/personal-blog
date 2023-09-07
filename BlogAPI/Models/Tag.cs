namespace BlogAPI.Models;

public class Tag
{
    public Guid TagId { get; set; }
    public string Name { get; set; }

    public Post Post { get; set; }

    public Tag()
    {
        this.TagId = Guid.NewGuid();
        this.Name = string.Empty;
        this.Post = new Post();
    }
}