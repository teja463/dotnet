using System.Reflection;

namespace ProjectA;

public class Reflections
{
    public void Sample()
    {

        Type type = Type.GetType("ProjectA.DelegateEmployee");
        PropertyInfo[] propertyInfos = type.GetProperties();
        foreach (PropertyInfo propertyInfo in propertyInfos)
        {
            Console.WriteLine($"Reflections: {propertyInfo.Name}");
        }

        MethodInfo[] methodInfos = type.GetMethods();
        foreach (MethodInfo methodInfo in methodInfos) 
        {
            Console.WriteLine("Reflections: "+methodInfo.Name );
        }
    }
}
