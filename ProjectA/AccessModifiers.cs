
namespace ProjectA;

class AccessEmployee
{
    internal string Name { get; set; }
    protected string Email { get; set; }
    protected internal string Phone { get; set; }
    public string Address { get; set; }

}

class FullAccessEmployee : AccessEmployee
{
    [Obsolete]
    public void PrintName()
    {
        Console.WriteLine(Name);
    }
}
public class AccessModifiers
{
    public void Access()
    {
        FullAccessEmployee fullAccessEmployee = new FullAccessEmployee();
        fullAccessEmployee.Name = "Teja";
        fullAccessEmployee.PrintName();
    }
}
