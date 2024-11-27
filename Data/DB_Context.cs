using Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class DB_Context : DbContext
{
    public DB_Context(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }
}