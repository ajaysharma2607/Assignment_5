using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    partial class Except
    {
        public void DivTwo()
        {
            double result = 0;
            bool validInput = false;

            while (!validInput)
            {
                try
                {
                    Console.Write("Enter the numerator: ");
                    double numerator = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the denominator: ");
                    double denominator = Convert.ToDouble(Console.ReadLine());

                    if (denominator == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }

                    result = numerator / denominator;
                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}
