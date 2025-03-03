using Microsoft.EntityFrameworkCore;
using webapi_withefcore.Model;

namespace webapi_withefcore.Data;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
        
    }
    public DbSet<User> User { get; set; }


}
