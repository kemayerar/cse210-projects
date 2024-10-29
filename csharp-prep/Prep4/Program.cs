using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int suma = 0;
        int maximum = 0;

        int number = -1;
        Console.WriteLine("Please start typing numbers");
        while (number != 0)
        {
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }
        Console.WriteLine();
        Console.WriteLine("Your list is the following:");
        foreach (int item in numbers)
        {
            if (item !=0 ){
                Console.WriteLine(item);
                suma = suma + item;
                if (item > maximum){
                    maximum = item;
                }
            }
        }
        Console.WriteLine($"Total sum is: {suma}");
        Console.WriteLine($"Largest number was {maximum}");
        float average = ((float)suma) / (numbers.Count - 1);
        Console.WriteLine($"Average was {average:0.00}");
    }
}