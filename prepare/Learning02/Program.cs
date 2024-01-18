using System;


class Program
{
    static void Main(string[] args)
    {
        
        Job Job1 = new Job();
        Job1._jobTitle = "enginer";
        Job1._company = "apple";
        Job1._startYear = 2020;
        Job1._endYear = 2021;

        //Job1.Display();
        
        Job Job2 = new Job();
        Job2._jobTitle = "support";
        Job2._company = "Microsoft";
        Job2._startYear = 2022;
        Job2._endYear = 2023;

        //Job2.Display();
        
        Resume resumeA = new Resume();
        resumeA._name = "Matias mancipe";

        resumeA._jobList.Add(Job1);
        resumeA._jobList.Add(Job2);

        resumeA.Display ();
                

    }
}