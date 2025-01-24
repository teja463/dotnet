namespace ProjectA;
public class Properties
{
    // read and write
    public string? Email { get; set; }

    private string? _name = "Sample";
    public string? Name
    {
        set
        {
            _name = value;
        }
        get
        {
            return _name;
        }
    }

    // readonly 
    public string Country
    {
        get
        {
            return "India";
        }
    }

    public Properties() { }
    public Properties(string ? email, string? name)
    {
        Email = email;
        _name = name;
    }
}

