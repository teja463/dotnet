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
        InterfaceDemo();

        Program p = new Program(); ;
        p.DelegateDemo();

        ExceptionsDemo();
        EnumsDemo();
        AccessModifiersDemo();
        ReflectionsDemo();
        GenericsDemo();
        EqualsHashCodeDemo();
        PartialDemo();
        IndexerDemo();
        ParamsDemo();
        CollectionsDemo();
        ThreadsDemo();
        Console.WriteLine("Main Thread finished");
    }

    private static async void ThreadsDemo()
    {
        Threads t = new Threads();
        Thread thread = new Thread(t.LongTask);
        Thread thread2 = new Thread(() =>
        {
            Console.WriteLine("Another Thread");
        });
        thread2.Start();
        thread.Start();
        int v = await t.AsyncTask();
        Console.WriteLine("V " + v);
    }

    private static void CollectionsDemo()
    {
        ListAndDictionary listAndDictionary = new ListAndDictionary();
        listAndDictionary.Demo();
    }

    private static void ParamsDemo()
    {
        Console.WriteLine("**************ParamsDemo");
        MethodParams p = new MethodParams();
        Console.WriteLine("Sum: " + p.SumParams(1, 2));
        Console.WriteLine("Sum: " + p.SumParams(1, 2, 3, 4, 5, 6));

        Console.WriteLine("Default: " + p.DefaultValues(1));
        Console.WriteLine("Default: " + p.DefaultValues(1, 3));
        Console.WriteLine("Default: " + p.DefaultValues(1, c: 4));
        Console.WriteLine("**************ParamsDemo");
    }

    private static void IndexerDemo()
    {
        Indexers indexers = new Indexers();
        Console.WriteLine(indexers[1]);
        indexers[1] = "Teja";
        Console.WriteLine(indexers[1]);
    }

    private static void PartialDemo()
    {
        PartialClass p = new PartialClass("Test", "Desc");
        p.PrintDetails();
    }

    private static void EqualsHashCodeDemo()
    {
        ToStringEqualsEtc one = new ToStringEqualsEtc("Teja", "Test");
        ToStringEqualsEtc two = new ToStringEqualsEtc("Teja", "Test");
        Console.WriteLine(one.Equals(two));
        Console.WriteLine(one == two);

    }

    private static void GenericsDemo()
    {
        Generics generics = new Generics();
        Console.WriteLine("Equals: " + generics.IsEqual(10, 10));
        GenericClass<int> genericClass = new GenericClass<int>();
        Console.WriteLine("Equals: " + genericClass.IsEqual(10, 10));
    }

    private static void ReflectionsDemo()
    {
        Reflections r = new Reflections();
        r.Sample();
    }

    private static void AccessModifiersDemo()
    {
        AccessModifiers a = new AccessModifiers();
        a.Access();
    }
    private static void EnumsDemo()
    {
        Enums e = new Enums("Teja", Gender.Male);
        Console.WriteLine($"{e.Name} {e.Gender}");
    }

    private static void ExceptionsDemo()
    {
        Exceptions e = new Exceptions();
        e.demo();
    }

    public bool Promote(DelegateEmployee employee)
    {
        if (employee.Experience > 5)
        {
            return true;
        }
        return false;
    }

    private void DelegateDemo()
    {
        DelegateEmployee teja = new DelegateEmployee("Teja", 12);
        DelegateEmployee ramya = new DelegateEmployee("Ramya", 2);
        DelegateEmployee havish = new DelegateEmployee("Havish", 5);
        List<DelegateEmployee> delegateEmployees = [ramya, havish, teja];

        IsPromotedDelegate delegatedPromotion = new IsPromotedDelegate(Promote);

        Delegates d = new Delegates();
        d.PromoteEmployee(delegateEmployees, delegatedPromotion);

        d.PromoteEmployee(delegateEmployees, emp => emp.Experience > 3);
    }

    private static void InterfaceDemo()
    {
        // Here the case is similar to java, both interfaces have same method and we are overriding it in a Class
        IDemo1 ic1 = new ImplicitInterface();
        ic1.print();
        IDemo2 ic2 = new ImplicitInterface();
        ic2.print();

        /* But if you want to have two versions of the same method based on the interfac then you can do it via Explicit overriding
         * You have to prefix the method name with interface name and .
        */
        IDemo1 ec1 = new ExplicitInterface();
        ec1.print();
        IDemo2 ec2 = new ExplicitInterface();
        ec2.print();
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
        POLY.Employee[] employees = new POLY.Employee[4];

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
        int sum = 0;
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