using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {

        int Choice = -1;
        Journal jour = new Journal();
        Generator prompts = new Generator();

        while (Choice != 5)

        {
            //if user select 1 give a prompt to write.

            Console.WriteLine("Welcome to the Journal program ");
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");

            Console.WriteLine("What do you like to do?");
            string _Choice = Console.ReadLine();
            Choice = int.Parse(_Choice);


            switch (Choice)
            {
                case 1:

                    string prompt = prompts.GetRandomQuestion();
                    Console.WriteLine(prompt);
                    string answer = Console.ReadLine();

                    Entry firstAnswer = new Entry();
                    firstAnswer._promptText = prompt;
                    firstAnswer._entryText = answer;

                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToString();
                    firstAnswer._date = dateText;

                    jour.AddEntry(firstAnswer);
                    break;
                case 2:
                    jour.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("Enter the file:");
                    string file = Console.ReadLine();
                    jour.LoadFromFile("myFile.txt");
                    break;
                case 4:
                    jour.SaveToFile("myFile.txt");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}