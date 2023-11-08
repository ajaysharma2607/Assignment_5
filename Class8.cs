using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    partial class Except
    {
        public void throwExcept(int numerator, int denominator)
        {
            try
            {
                if (denominator == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
                int result = numerator / denominator;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Caught an exception: {ex.Message}");
                throw; // Rethrow the exception
            }
        }
    }

    }
}
