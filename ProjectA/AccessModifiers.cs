
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
    public void PrintName()
    {
        Console.WriteLine(Name);
    }
}
class AccessModifiers
{
    public static void Access()
    {
        FullAccessEmployee fullAccessEmployee = new FullAccessEmployee();
        fullAccessEmployee.Name = "Teja";
        fullAccessEmployee.PrintName();
    }
}
