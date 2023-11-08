using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    partial class Except
    {
        public void Cal()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter an operation (+, -, *, /): ");
                    char operation = Console.ReadLine()[0];

                    Console.Write("Enter the first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double result = 0;

                    switch (operation)
                    {
                        case '+':
                            result = num1 + num2;
                            break;
                        case '-':
                            result = num1 - num2;
                            break;
                        case '*':
                            result = num1 * num2;
                            break;
                        case '/':
                            if (num2 == 0)
                            {
                                throw new DivideByZeroException("Cannot divide by zero.");
                            }
                            result = num1 / num2;
                            break;
                        default:
                            Console.WriteLine("Invalid operation. Please enter +, -, *, or /.");
                            continue;
                    }

                    Console.WriteLine($"Result: {result}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter valid numbers.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
