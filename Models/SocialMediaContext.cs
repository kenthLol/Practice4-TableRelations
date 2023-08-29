using Microsoft.EntityFrameworkCore;

namespace P4TableRelations.Models;
public class SocialMediaContext : DbContext {
    public SocialMediaContext(DbContextOptions<SocialMediaContext> options) : base (options) { }

    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }
}