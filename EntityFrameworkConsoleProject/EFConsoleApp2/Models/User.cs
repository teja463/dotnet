using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp2.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    
    public string? Email { get; set; }

    public ICollection<Post> Posts { get; set; } = new List<Post>();


}
