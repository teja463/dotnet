using System;
class Program()
{
    public static void Main()
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
}