using System;
class LoopsFunctions
{
    public static void Run()
    {
        Console.WriteLine("Numbers from 1 to 10:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        string input;
        do
        {
            Console.Write("Enter something (type 'exit' to quit): ");
            input = Console.ReadLine() ?? string.Empty;
        } while (input.ToLower() != "exit");

        Console.Write("Enter a number to calculate factorial: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Factorial of {number} is {Factorial(number)}");
    }
    private static long Factorial(int n)
    {
        long fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }
        return fact;
    }
}
