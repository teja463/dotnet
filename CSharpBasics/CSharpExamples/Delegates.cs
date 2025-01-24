
namespace ProjectA;


public delegate bool IsPromotedDelegate(DelegateEmployee emp);

public class DelegateEmployee
{
    public string Name { get; set; }
    public int Experience { get; set; }

    public DelegateEmployee(string Name, int Experience)
    {
        this.Name = Name;
        this.Experience = Experience;
    }

}

public class Delegates
{

    public void PromoteEmployee(List<DelegateEmployee> employees, IsPromotedDelegate isPromoted)
    {
        foreach (DelegateEmployee employee in employees)
        {

            if (isPromoted(employee))
            {
                Console.WriteLine($"Employee {employee.Name} is promoted");
            }
        }
    }

}
