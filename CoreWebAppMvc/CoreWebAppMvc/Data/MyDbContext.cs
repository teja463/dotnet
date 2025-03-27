using CoreWebAppMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreWebAppMvc.Data;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<SerialNumber>().HasData(
            new SerialNumber {Id=1,  Name="HDD1", ItemId =1 }
            );
        Console.WriteLine("On Model Creating..............");
    }

    public DbSet<Item> Items { get; set; }

    public DbSet<SerialNumber> SerialNumbers { get; set; }


}
