namespace ProjectA;

public enum Gender
{
    Male,
    Female,
    Unknown
}
public class Enums
{
    public Gender Gender { get; set; }

    public string Name { get; set; }

    public Enums(string Name, Gender Gender)
    {
        this.Name = Name;
        this.Gender = Gender;
    }
}
