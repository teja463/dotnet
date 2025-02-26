using EntityFrameworkConsoleProject.Data;
using EntityFrameworkConsoleProject.Models;
using Microsoft.EntityFrameworkCore;

// For Creating and saving entries in Database

using MyDBContext db = new MyDBContext();

//CreateData();
//ReadData();
//UpdateData();
//ReadData();
//DeleteData();

UserDemo();

void UserDemo()
{
    /*Random random = new() { };

    User teja = new User()
    {
        Name = $"Teja {random.Next(100)}",
        Phone = $"9879462{random.Next(10)}"
    };
    db.Users.Add(teja);
    Address address = new Address()
     {
         State = "TG",
         Country = "IN",
         UserId = 1
     };

    address.User = teja;
     db.Address.Add(address);
     db.SaveChanges();*/

    User? user = db.Users.Include(u => u.Addresses).Where(u => u.Id == 1).FirstOrDefault();
    Console.WriteLine(user);
    foreach (var item in user.Addresses)
    {
        Console.WriteLine(item);
    }
}

void CreateData()
{
    Random random = new Random();
    int r = random.Next(100);
    Product veggieSpecial = new Product()
    {
        Name = "Veggie Special Pizza" + r,
        Price = 9.99M * r
    };

    db.Products.Add(veggieSpecial);

    Product deluxMeat = new ()
    {
        Name = "Delux Meat Pizza" + r,
        Price = 13.22M * r
    };

    db.Add(deluxMeat);

    db.SaveChanges();
}

void ReadData()
{

    List<Product> products = db.Products.ToList();
    PrintProducts(products);

    // fluent API syntax
    List<Product> products2 = db.Products.Where(p => p.Price > 10.00M).OrderBy(p => p.Name).ToList();
    PrintProducts(products2);

    IOrderedQueryable<Product> products1 = from product in db.Products
                                           where product.Price > 10.00M
                                           orderby product.Name
                                           select product;

    PrintProducts(products1.ToList());
}

void UpdateData()
{
    var product1 = from product in db.Products select product;
    Product product2 = product1.Take(1).First();
    product2.Price = 20.11M;
    db.SaveChanges();
}

void DeleteData()
{
    Product? product = db.Products.Where(p => p.Id == 1).FirstOrDefault();
    if(product != null)
    {
        db.Remove(product);
        db.SaveChanges();
    }

}

void PrintProducts(List<Product> products)
{
    foreach (var item in products)
    {
        PrintProduct(item);
    }
}

static void PrintProduct(Product item)
{
    Console.WriteLine($"ID {item.Id}");
    Console.WriteLine($"Name {item.Name}");
    Console.WriteLine($"Price {item.Price}");
    Console.WriteLine(new string('-', 20));
}