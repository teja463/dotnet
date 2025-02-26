using EFConsoleApp2.Models;
using EFConsoleApp2.Data;
using Microsoft.EntityFrameworkCore;

using MyDBContext database = new MyDBContext();

User user = database.User.Include(a => a.Posts).Where(u => u.Id == 1).First();
Console.WriteLine($"{user.Name} {user.Email}");
foreach (var post in user.Posts)
{
    Console.WriteLine($"\t {post.Title} {post.Summary}");
}