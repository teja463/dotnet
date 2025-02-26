using EFConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;

namespace EFConsoleApp2.Data;

public class MyDBContext : DbContext
{

    public DbSet<User> User { get; set; }

    public DbSet<Post> Post { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=ContosoPizza2;Integrated Security=True;TrustServerCertificate=True;");
    }
}
