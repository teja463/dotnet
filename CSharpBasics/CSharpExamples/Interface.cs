namespace ProjectA;

public interface IDemo1
{
    void print();
}

public interface IDemo2
{
    void print();
}

// 
public class ImplicitInterface : IDemo1, IDemo2
{
    public void print()
    {
        Console.WriteLine("Implicit implementation");
    }
}

public class ExplicitInterface : IDemo1, IDemo2
{
    void IDemo1.print()
    {
        Console.WriteLine("Explicit IDemo1 Printing");
    }

    void IDemo2.print()
    {
        Console.WriteLine("Explicit IDemo2 Printing");
    }
}

