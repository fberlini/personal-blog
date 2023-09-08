namespace BlogAPI.Models;

public class Source
{
    public Guid SourceId { get; set; }
    public string Title { get; set; }
    public string Link { get; set; }

    public Post Post { get; set; }

    public Source()
    {
        this.SourceId = Guid.NewGuid();
        this.Title = string.Empty;
        this.Link = string.Empty;
        this.Post = new Post();
    }
}
