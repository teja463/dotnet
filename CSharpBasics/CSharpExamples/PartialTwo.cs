namespace ProjectA;

public partial class PartialClass
{

    partial void PartialMethod();

    public void PrintDetails()
    {
        Console.WriteLine($"Details: {Name} {Description} ");
        PartialMethod();
    }
}
