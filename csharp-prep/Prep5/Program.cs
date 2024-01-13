using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Hello Prep5 World!");
       displayWelcomems();
       string uname = username ();
       int number = unumber ();

       int sqnumber = doble(number);
       displayresult(uname, sqnumber);

       
    }
    static void displayWelcomems()
    {
        Console.WriteLine("welcome to the program");
    }

    static string username()
    {
        Console.Write("enter your name: ");
        string name = Console.ReadLine();
        return name;
        
    }
    static int unumber()
    {
        Console.WriteLine("enter your favorite number: ");
        int answernumber = int.Parse(Console.ReadLine());

        return answernumber;
    }

    static int doble(int answernumber)
    {
        int square = answernumber * answernumber;

        return square;
    }

    static void displayresult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");


    }
}


