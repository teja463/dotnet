namespace ProjectA
{
    public class Employee
    {
        private string FirstName;
        private string LastName;

        // Static constructor is similar to static blocks in java, it is the first thing to be called
        static Employee()
        {
            Console.WriteLine("Static Constructor");
        }

        // invoke other constructors similar to calling this() in java inside default constructor
        public Employee() : this("No FirstName", "No LastName") 
        {
            Console.WriteLine("Default Constructor");
        }
        public Employee(string FirstName, string LastName)
        {
            Console.WriteLine("Parameterized Constructor");
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public void SayHello()
        {
            Console.WriteLine($"Hello {this.FirstName} {this.LastName}");
        }

        // Destructor
        ~Employee()
        {
            Console.WriteLine("Destructor");
        }
    }
}
