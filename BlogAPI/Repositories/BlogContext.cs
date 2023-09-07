using BlogAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogAPI.Repositories;

public class BlogContext : DbContext
{
    public DbSet<Author> Authors{ get; set; }
    public DbSet<Source> Sources{ get; set; }
    public DbSet<Tag> Tags{ get; set; }
    public DbSet<Post> Posts{ get; set; }

    public BlogContext(DbContextOptions<BlogContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>().ToTable("Author");
        modelBuilder.Entity<Source>().ToTable("Source");
        modelBuilder.Entity<Tag>().ToTable("Tag");
        modelBuilder.Entity<Post>().ToTable("Post");
    }
}