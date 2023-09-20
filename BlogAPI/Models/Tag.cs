namespace BlogAPI.Models;

public class Tag
{
    public Guid TagId { get; set; }
    public required string Name { get; set; }

    public Post? Post { get; set; }
}