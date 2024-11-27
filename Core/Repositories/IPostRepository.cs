using Data.Entity;

namespace Core.Repositories;

public interface IPostRepository
{
    Post GetPostById(int id);
    List<Post> GetPosts();
}