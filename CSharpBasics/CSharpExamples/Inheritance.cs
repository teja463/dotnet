﻿namespace ProjectA;

public class BaseEmployee
{
    protected string FirstName;
    protected string LastName;

    public BaseEmployee(string FirstName, string LastName)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
    }
    public void PrintName()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }
}

public class FullTimeEmployee : BaseEmployee
{
    public double Salary;
    public FullTimeEmployee(string FirstName, string LastName, double Salary) : base(FirstName, LastName)
    {
        this.Salary = Salary;
    }
}

public class PartTimeEmployee : BaseEmployee
{
    public double HourlyRate;
    public PartTimeEmployee(string FirstName, string LastName, double HourlyRate) : base(FirstName, LastName)
    {
        this.HourlyRate = HourlyRate;
    }
}



