using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        Console.WriteLine("Random number generated!");
        int guess = 0;
        while (number != guess)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            
            if (number > guess)
            {
                Console.WriteLine("Higher");
                Console.WriteLine();
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Congrats! you escaped the matrix");
                Console.WriteLine();
            }
        } 

    }
}