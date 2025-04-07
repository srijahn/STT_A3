using System;
class ExceptionHandling
{   
  public static void Run()
    {
        try
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine($"Sum: {sum} ({(sum % 2 == 0 ? "Even" : "Odd")})");
            Console.WriteLine($"Multiplication: {num1 * num2}");
            Console.WriteLine(num2 != 0 ? $"Division: {num1 / num2}" : "Cannot divide by zero");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter a number.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
