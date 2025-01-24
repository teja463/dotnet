namespace ProjectA.Polymorphism;

public class Employee
{
    public string FirstName;
    public string LastName;

    public Employee(string FirstName, string LastName)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
    }
    public virtual void PrintName()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }
}

public class FullTimeEmployee : Employee
{
    public FullTimeEmployee(string FirstName, string LastName) : base(FirstName, LastName)
    {
    }

    public override void PrintName()
    {
        Console.WriteLine($"{FirstName} {LastName} --- Fulltime");
    }
}

public class PartTimeEmployee : Employee
{
    public PartTimeEmployee(string FirstName, string LastName) : base(FirstName, LastName)
    {
    }

    public override void PrintName()
    {
        Console.WriteLine($"{FirstName} {LastName} --- Parttime");
    }
}

public class TemporaryEmployee : Employee
{
    public TemporaryEmployee(string FirstName, string LastName) : base(FirstName, LastName)
    {
    }

}
