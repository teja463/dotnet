
namespace EntityFrameworkConsoleProject.Models;

public class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Phone { get; set; }

    public ICollection<Address> Addresses { get; set; } = new List<Address>();

    public override string? ToString()
    {
        return $"{Id} - {Name} - ${Phone}";
    }
}
