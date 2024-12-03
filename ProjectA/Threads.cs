namespace ProjectA;

public class Threads
{
    public void LongTask()
    {
        Console.WriteLine("Task Started");
        Thread.Sleep(4000);
        Console.WriteLine("Task Finished");
    }

    public async Task<int> AsyncTask()
    {
        Thread.Sleep(2000);
        return 20;
    }

}
