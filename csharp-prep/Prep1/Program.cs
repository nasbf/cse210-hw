using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string name = Console.ReadLine ();
        Console.WriteLine("what is your last name? ");
        string lname = Console.ReadLine ();
        Console.WriteLine($"your name is {lname}, {name} {lname} ");
    }
}