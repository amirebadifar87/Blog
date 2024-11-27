using Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers;

public class PostController : Controller
{
    IPostRepository _post;

    public PostController(IPostRepository post)
    {
        _post = post;
    }
    [Route("/post/{id}")]
    public IActionResult ShwoPost(int id)
    {
        return View(model:_post.GetPostById(id));
    }
}