using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade percentage? ");
        string number = Console.ReadLine();
        int grade = int.Parse (number);

        string letter = " ";

        if (grade >= 90)
        {
            letter =  "A";
        }
        else if (grade >= 80)
        {
            letter =  "B";
        }
        else if (grade >= 70)
        {
            letter =  "C";
        }
        else if (grade >= 60)
        {
            letter =  "D";
        }
        else
        {
            letter =  "F";
        }
        Console.WriteLine($"Your letter grade is {letter}");

        if (grade >=70)
        {
            Console.WriteLine("Congratulations you pass this course");
        }
        else
        {
            Console.WriteLine("next time you'll achieve this goal ");
        }
    }
}