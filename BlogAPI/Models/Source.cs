namespace BlogAPI.Models;

public class Source
{
    public Guid SourceId { get; set; }
    public required string Title { get; set; }
    public required string Link { get; set; }

    public Post? Post { get; set; }
}
