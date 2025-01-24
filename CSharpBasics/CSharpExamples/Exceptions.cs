namespace ProjectA;

public class Exceptions
{

    public class MyException : Exception
    {
        public MyException() { }
        public MyException(string message) : base(message) { }

        public MyException(string message, Exception innerException) : base(message, innerException) { }
    }
    public void demo()
    {
        try
        {
            int a = 1;
            int b = 0;
            try
            {

                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                throw new MyException("Custom exception", e);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.InnerException.Message);
        }

    }
}
