using EntityFrameworkConsoleProject.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkConsoleProject.Data;

public class MyDBContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers{ get; set; }
    public DbSet<Order> Orders{ get; set; }
    public DbSet<OrderDetail> OrderDetails{ get; set; }

    public DbSet<User> Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=ContosoPizza;Integrated Security=True;TrustServerCertificate=True;");
    }
}
