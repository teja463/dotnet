using System.Linq;
using System.Runtime.InteropServices;

namespace ProjectA;

public class MethodParams
{
    public int SumParams(int a, int b, params int[] extras)
    {
        foreach(int i in extras)
        {
            Console.WriteLine("Iteration: "+ i);
        }
        return a + b + extras.Sum();
    }

    public int DefaultValues(int a, int b = 0, int c = 0)
    {
        return a + b + c;
    }
}
