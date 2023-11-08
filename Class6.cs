using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{

    partial class Except
    {
        public void inner()
        {
            try
            {
                Console.WriteLine("Outer try block entered.");
                int a = 10;
                int b = 0;

                try
                {
                    Console.WriteLine("Inner try block entered.");
                    // Simulate an exception in the inner block
                    int result = a / b; // This will throw a DivideByZeroException
                    Console.WriteLine("This line won't be executed in the inner try block.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Caught an exception in the inner catch block: " + ex.Message);
                }

                Console.WriteLine("This line will be executed in the outer try block.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught an exception in the outer catch block: " + ex.Message);
            }

            Console.WriteLine("Program continues executing after exception handling.");
        }
    }
}
