using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleProject.Models;

public class Address
{
    public int Id { get; set; }

    public string? Street { get; set; }
    public string State { get; set; } = null!;
    public string Country { get; set; } = null!;
    public string? Zipcode { get; set; }

    public int UserId { get; set; }

    public User User { get; set; }

    public override string? ToString()
    {
        return $"{Id} {Street} {State} {Country}";
    }
}
