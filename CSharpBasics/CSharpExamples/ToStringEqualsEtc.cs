namespace ProjectA;

public class ToStringEqualsEtc
{
    public string Name { get; set; }
    public string Description { get; set; }

    public ToStringEqualsEtc(string name, string description)
    {
        Name = name; Description = description;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }
        ToStringEqualsEtc that = (ToStringEqualsEtc)obj;
        return Name.Equals(that.Name) && Description.Equals(that.Description);
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode() ^ Description.GetHashCode();
    }
}