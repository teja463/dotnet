Console.WriteLine("Hello, World!!!");

string userName = "Teja";
Console.WriteLine($"Your friends are {userName}");

int count = 0;
while (count < 5)
{
  count = count + 1;
  Console.Write(count + ", ");
}
Console.WriteLine();

for (int i = 0; i < 5; i++)
{
  if (i % 2 == 0)
  {
    Console.Write(i + ", ");
  }
}
Console.WriteLine();



List<string> names = new List<string>() { "Teja", "Ramya", "Havish" };
names.Add("Sample");

foreach (var name in names)
{
  Console.WriteLine($"Your name is {name}");
}

Console.WriteLine(names[^1]);

foreach (var nam in names[2..4])
{
  Console.WriteLine($"Your name is {nam}");
}

List<int> numbers = [23, 5, 56, 45, 225, 4546, 2333, 90];

var greaterThan80 = from number in numbers where number > 80 orderby number descending select number;

foreach (var num in greaterThan80)
{
  Console.Write(num + ",");
}
Console.WriteLine();

var greaterThan802 = numbers.Where(num => num > 80).OrderByDescending(num => num);

foreach (var num in greaterThan802)
{
  Console.Write(num + ",");
}
Console.WriteLine();

var teja = new Person("Teja", "P", new DateOnly(1989,06,06));
Console.WriteLine(teja + "hello");

class Person(){
  
  public Person(string firstname, string lastname, DateOnly dob): this(){
    this.firstname = firstname;
    this.lastname = lastname;
    this.dob = dob;
  }

  private string firstname {get; set;}
  private string lastname{get;set;}

  private DateOnly dob {get;set;}
}

