using BlogAPI.Models;
using BlogAPI.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BlogAPI;

public static class Extensions
{
    public static void UseDbSeeding(this IApplicationBuilder app)
    {
        var factory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
        
        using var serviceScope = factory.CreateScope();
        using var context = serviceScope.ServiceProvider.GetRequiredService<BlogContext>();
        context.Database.EnsureDeleted();
        context.Database.Migrate();

        var author = new Author
        {
            AuthorId = new Guid(),
            FullName = "Felipe Berlini"
        };

        context.Add(author);

        var source = new Source
        {
            SourceId = new Guid(),
            Title = "Title testing",
            Link = "www.google.com"
        };

        context.Add(source);

        var tag = new Tag
        {
            TagId = new Guid(),
            Name = "Testing tag"
        };

        context.Add(tag);

        context.Add(new Post
        {
            PostId = new Guid(),
            CreatedDate = DateTime.Today,
            Title = "Article title test",
            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla euismod purus eget tellus porttitor vehicula. Maecenas eget dui dapibus, mattis nulla at, rhoncus orci. Maecenas nulla quam, accumsan sit amet consectetur ac, blandit vitae justo.Proin viverra tincidunt enim vel fringilla. Sed in hendrerit enim. Aenean malesuada turpis nec quam rutrum elementum. Curabitur interdum nisl vitae nisl finibus, eu ultricies ligula fermentum.",
            Authors = new List<Author>(new [] {author}),
            Sources = new List<Source>(new [] {source}),
            Tags = new List<Tag>(new [] {tag})
        });

        context.SaveChanges();
    }
}