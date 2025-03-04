using System.ComponentModel.DataAnnotations.Schema;

namespace webapi_withefcore.Model;

[Table("User")]
public class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Email { get; set; }

    public ICollection<Post> UserPosts { get; set; } = new List<Post>();

}
