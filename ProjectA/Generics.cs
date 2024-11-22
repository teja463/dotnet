namespace ProjectA;

public class Generics
{
    public bool IsEqual<T>(T a, T b)
    {
        return a.Equals(b);
    }
}

public class GenericClass<T>
{
    public bool IsEqual(T a, T b)
    {
        return a.Equals(b);
    }
}
