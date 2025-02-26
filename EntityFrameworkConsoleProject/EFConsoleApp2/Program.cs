using EFConsoleApp2.Models;
using EFConsoleApp2.Data;
using Microsoft.EntityFrameworkCore;

using MyDBContext database = new MyDBContext();

List<User> users = database.User.Include(a => a.Posts).ToList();

foreach (var user in users)
{
    Console.WriteLine($"{user.Name} {user.Email}");
    if (user.Posts.Any())
    {
        foreach (var post in user.Posts)
        {
            Console.WriteLine($"\t {post.Title} {post.Summary}");
        }
    }
}

