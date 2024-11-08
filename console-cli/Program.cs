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