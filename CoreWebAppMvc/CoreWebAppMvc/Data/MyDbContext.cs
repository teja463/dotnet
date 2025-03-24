using CoreWebAppMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreWebAppMvc.Data;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Item> Items { get; set; }


}
