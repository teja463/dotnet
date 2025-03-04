using Microsoft.AspNetCore.Mvc;
using webapi_withefcore.Data;
using webapi_withefcore.Model.Response;

namespace webapi_withefcore.Controllers;

[Route("/api/[controller]")]
[ApiController]
public class PostsController : ControllerBase
{
    private readonly MyDbContext myDbContext;

    public PostsController(MyDbContext myDbContext)
    {
        this.myDbContext = myDbContext;
    }

    [HttpGet]
    public List<PostDetail> AllPosts()
    {
        List<PostDetail> posts = (from p in myDbContext.Posts
                                  join u in myDbContext.Users on p.UserId equals u.Id
                                  select new PostDetail
                                  {
                                      PostId = p.Id,
                                      PostTitle = p.Title,
                                      UserId = u.Id,
                                      UserName = u.Name
                                  }).ToList();
        return posts;
    }
}
