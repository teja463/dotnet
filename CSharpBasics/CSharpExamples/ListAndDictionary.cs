namespace ProjectA;

internal class Customer
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }

    public int Income { get; set; }

    public override string ToString()
    {
        return "{"+$"CustomerId={CustomerId}, CustomerName={CustomerName}"+"}";

    }
}

public class ListAndDictionary
{

    List<Customer> customers = new List<Customer>();
    public ListAndDictionary()
    {
        customers.Add(new Customer { CustomerId = 1, CustomerName = "Test1", Income = 35000 });
        customers.Add(new Customer { CustomerId = 2, CustomerName = "Test2", Income = 25000 });
        customers.Add(new Customer { CustomerId = 3, CustomerName = "Test3", Income = 40000 });
        customers.Add(new Customer { CustomerId = 4, CustomerName = "Test4", Income = 29000 });
    }
    public void Demo()
    {
        Console.WriteLine();
        foreach (Customer c in customers)
        {
            Console.Write(c.CustomerName + ",");
        }
        Console.WriteLine();
        Dictionary<int, Customer> dictionary = customers.ToDictionary(cust => cust.CustomerId);
        foreach(KeyValuePair<int, Customer> entry in dictionary)
        {
            Console.Write(entry.Key +"="+ entry.Value.ToString()+",");
        }
        Console.WriteLine();

        Console.WriteLine(customers.Find(cust => cust.CustomerId == 1));

    }
}
