using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Switch();
        }

        static double sub(double x, double y) => x - y;
        static double add(double x, double y) => x + y;
        static double multi(double x, double y) => x * y;
        static double div(double x, double y) => x / y;

        static void Switch()
        {
            char x;
            do
            {
                Console.WriteLine("Choose operation:\na - Add\nb - Subtract\nc - Multiply\nd - Divide\ne - Exit");
                x = char.ToLower(Console.ReadLine()[0]);

                if (x == 'e') break;

                if (x != 'a' && x != 'b' && x != 'c' && x != 'd')
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                Console.Write("Enter the first number: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Invalid number. Try again.");
                    continue;
                }

                Console.Write("Enter the second number: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Invalid number. Try again.");
                    continue;
                }

                switch (x)
                {
                    case 'a':
                        Console.WriteLine($"Result: {add(num1, num2)}");
                        break;
                    case 'b':
                        Console.WriteLine($"Result: {sub(num1, num2)}");
                        break;
                    case 'c':
                        Console.WriteLine($"Result: {multi(num1, num2)}");
                        break;
                    case 'd':
                        if (num2 != 0)
                            Console.WriteLine($"Result: {div(num1, num2)}");
                        else
                            Console.WriteLine("Error: Cannot divide by zero.");
                        break;
                }

            } while (true);
        }
    }
}
