using System;
using System.Data.Common;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
         int unumber = -1;   
        Console.WriteLine("Enter a list of number, type 0 to finish");
        
        while (unumber != 0)
        {
            
            Console.WriteLine("Enter a number");
            string usernumber = Console.ReadLine();
            unumber = int.Parse(usernumber);

            if (unumber != 0)
            {
                numbers.Add(unumber);
            }
       }

       int sum = 0;

       foreach (int number in numbers)
       {
        sum += number;
       }

       Console.WriteLine($"the sum is {sum}");

       int average = sum / numbers.Count;

       Console.WriteLine($"the average is {average}");

       int mayor  = numbers[0];
       foreach (int number in numbers)
       {
        
        if (number > mayor)
        {
            mayor = number;
        }
       }

        Console.WriteLine($"the mayor is {mayor}");




        
    
    }
}