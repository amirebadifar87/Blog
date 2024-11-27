using Data.Entity.Tbl;
using Microsoft.EntityFrameworkCore;

namespace Data.Entity;

public class DB_Context : DbContext
{
    public DB_Context(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }
}