namespace ProjectA;

public partial class PartialClass
{
    public string Name { get; set; }
    public string Description { get; set; }

    public PartialClass(string name, string description)
    {
        Name = name;
        Description = description;
    }

    partial void PartialMethod()
    {
        Console.WriteLine("Partial Method Called");
    }

}
