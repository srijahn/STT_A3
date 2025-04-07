using System;
class BasicOperations
{
    public static void Run()
    {
        Console.Write("Enter first number: ");   // accept user input 
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Perform operations
        int sum = num1 + num2;
        int difference = num1 - num2;
        int product = num1 * num2;
        double quotient = (num2 != 0) ? (double)num1 / num2 : double.NaN;

        string sumType = (sum % 2 == 0) ? "even" : "odd"; // Check if sum is even or odd

        // Results
        Console.WriteLine($"Addition: {sum} ({sumType})");
        Console.WriteLine($"Subtraction: {difference}");
        Console.WriteLine($"Multiplication: {product}");
        Console.WriteLine($"Division: {(num2 != 0 ? quotient.ToString() : "Cannot divide by zero")}");
    }
}
