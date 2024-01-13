using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        //Console.Write("What is the magic number? ");
        //string number = Console.ReadLine();
        
        Random randomGenerator = new Random();
        int mnumber = randomGenerator.Next(1, 20);
        
        int guess = -1;

        while (guess != mnumber)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
     

            if (guess > mnumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < mnumber)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.WriteLine("is correct!!");
            }
        }
    }


}



