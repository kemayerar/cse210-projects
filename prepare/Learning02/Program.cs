using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._companyName = "Apple";
        job1._jobTitle = "Software Developer";
        job1._startYear = 2018;
        job1._endYear = 2024;

        string sentence = job1.Display();
        Console.WriteLine(sentence);
    }
}