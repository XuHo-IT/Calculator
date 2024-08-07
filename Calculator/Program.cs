using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            float result;
            string answer;

            Console.WriteLine("Hello, welcome to the calculator program!");

            while (true)
            {
                Console.WriteLine("Please enter your first number:");
                if (!float.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid input, please enter a valid number.");
                    continue;
                }

                Console.WriteLine("Please enter your second number:");
                if (!float.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid input, please enter a valid number.");
                    continue;
                }

                Console.WriteLine("What type of operation would you like to do?");
                Console.WriteLine("Please enter 'a' for addition, 's' for subtraction, 'm' for multiplication, 'd' for division, or 'x' to exit.");

                answer = Console.ReadLine();

                if (answer == "x")
                {
                    Console.WriteLine("Thank you for using the calculator program!");
                    break;
                }

                switch (answer)
                {
                    case "a":
                        result = num1 + num2;
                        break;
                    case "s":
                        result = num1 - num2;
                        break;
                    case "m":
                        result = num1 * num2;
                        break;
                    case "d":
                        result = num2 == 0 ? float.NaN : num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operation selected. Please try again.");
                        continue;
                }

                if (float.IsNaN(result))
                {
                    Console.WriteLine("Cannot divide by 0.");
                }
                else
                {
                    Console.WriteLine("The result is: " + result);
                }
            }

            Console.ReadKey();
        }
    }
}
