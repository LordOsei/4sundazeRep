using Microsoft.EntityFrameworkCore;

public class TwitterCloneContext : DbContext
{
    public TwitterCloneContext(DbContextOptions<TwitterCloneContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
}
