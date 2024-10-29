using System;

class Program
{
    static void Main(string[] args)
    {
        Welcomer();

        string name = NameAsker();
        int number = NumberAsker();
        string squaredNumber = SquareMaker(number).ToString();

        Displayer(name, squaredNumber);

    }
    static void Welcomer()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string NameAsker()
    {
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int NumberAsker()
    {
        Console.WriteLine("Please insert a random number ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareMaker(int number2)
    {
        int square = number2 * number2;
        string newSquare = square.ToString();
        return square;
    }
    static void Displayer(string name, string square)
    {
        Console.WriteLine($"your new username is {name}{square}");
    }

}