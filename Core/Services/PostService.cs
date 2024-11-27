using Core.Repositories;
using Data;
using Data.Entity;

namespace Core.Services;

public class PostService : IPostRepository
{
    private DB_Context _context;

    public PostService(DB_Context context)
    {
        _context = context;
    }

    public Post GetPostById(int id)
    {
        return _context.Posts.SingleOrDefault(p => p.Id == id);
    }

    public List<Post> GetPosts()
    {
       return _context.Posts.ToList();
    }
}