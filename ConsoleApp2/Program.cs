using System;
using ProjectA;
using POLY = ProjectA.Polymorphism;
class Program()
{
    public static void Main()
    {
        ReadConsole();
        NullCoalescing();
        PassByRef();
        OutParams();
        ClassDemo();
        InheritanceDemo();
        PolymorphismDemo();
        PropertiesDemo();
    }

    private static void PropertiesDemo()
    {
        // 3 Different ways to intialize a object one with properites, another with constructor and another with {}
        Properties properties = new Properties();
        properties.Name = "Teja";
        properties.Email = "Teja@gmail.com";
        Console.WriteLine($" {properties.Name} {properties.Email} {properties.Country}");

        Properties properties2 = new Properties("Test2@test.com", "Test2");
        Console.WriteLine($" {properties2.Name} {properties2.Email} {properties2.Country}");

        Properties properties3 = new Properties
        {
            Name = "Test3",
            Email = "Test3@test.com"
        };
        Console.WriteLine($" {properties3.Name} {properties3.Email} {properties3.Country}");
    }
    private static void PolymorphismDemo()
    {
        POLY.Employee[] employees= new POLY.Employee[4];

        employees[0] = new POLY.Employee("Test", "A");
        employees[1] = new POLY.FullTimeEmployee("Test", "A");
        employees[2] = new POLY.PartTimeEmployee("Test", "A");
        employees[3] = new POLY.TemporaryEmployee("Test", "A");

        foreach (var employee in employees)
        {
            employee.PrintName();
        }
    }

    private static void InheritanceDemo()
    {
        BaseEmployee fte = new FullTimeEmployee("Teja", "P", 2324434);
        fte.PrintName();
    }

    private static void ClassDemo()
    {
        Employee NoEmp = new Employee();
        NoEmp.SayHello();

        Employee emp = new Employee("Teja", "P");
        emp.SayHello();
    }

    private static void OutParams()
    {
        // if you want to return multiple value then you can use out params
        int a = 20;
        int b = 30;
        int mul = 0;
        int sum= 0;
        UseOutParams(a, b, out sum, out mul);
        Console.WriteLine($"Sum is {sum} Multiple is {mul}");
    }

    private static void PassByRef()
    {
        // b value is changed to 30 because we are passing it as a reference
        int a = 1;
        int b = 2;
        updateParams(a, ref b);
        Console.WriteLine($" a {a}  b {b}");
    }

    
    private static void NullCoalescing()
    {
        int? count = 2;
        //int? count = null;
        int? count2 = count ?? 50;
        Console.WriteLine("Count2 is " + count2);
        if (count == null)
        {
            Console.WriteLine("Count is null");
        }
        else if (count > 20)
        {
            Console.WriteLine($"Coutn value is {count} is greater than 20");
        }
        else
        {
            Console.WriteLine($"count is less than 20: {count}");
        }
    }

    private static void ReadConsole()
    {
        bool read = false;
        if (read)
        {
            Console.WriteLine("Enter your name");
            String name = Console.ReadLine();
            Console.WriteLine($"Your name is {name}");
        }

        // verbatime dont infer escape character, show them as it is 
        Console.WriteLine(@"c:\\Collins\\Test\\A");
    }

    private static void updateParams(int a, ref int b)
    {
        a = 20;
        b = 30;
    }

    private static void UseOutParams(int a, int b, out int sum, out int mul)
    {
        sum = a + b;
        mul = a * b;
    }
}