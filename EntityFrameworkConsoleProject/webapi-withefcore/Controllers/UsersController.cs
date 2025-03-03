using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using webapi_withefcore.Data;
using webapi_withefcore.Model;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace webapi_withefcore.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{

    private readonly MyDbContext myDbContext;

    public UsersController(MyDbContext myDbContext)
    {
        this.myDbContext = myDbContext;
    }

    [HttpGet]
    public List<User> FindAllUsers()
    {
        return myDbContext.User.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<User> FindUserById(int id)
    {
        User? user = myDbContext.User.Find(id);
        if(null== user)
        {
            return NotFound();
        }

        return user;
    }

    [HttpPost]
    public ActionResult<User> AddUser([FromBody] User user)
    {
        myDbContext.User.Add(user);
        myDbContext.SaveChanges();
        return user;
    }

    [HttpPut("{id}")]
    public User UpdateUser([FromRoute] int id, [FromBody] User user) 
    {
        user.Id = id;
        EntityEntry<User> userEntry = myDbContext.Entry(user);
        userEntry.State = EntityState.Modified;
        myDbContext.SaveChanges();
        return user;
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteUser(int id)
    {
        User? user = myDbContext.User.Find(id);
        if(null == user)
        {
            return NotFound();
        }

        myDbContext.User.Remove(user);
        myDbContext.SaveChanges();

        return Ok(user);
    }
}