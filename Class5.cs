using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{


    partial class Except
    {
        public void Multi()
        {
            try
            {
                // Simulate an IndexOutOfRangeException
                int[] numbers = { 1, 2, 3 };
                int value = numbers[3];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException: " + ex.Message);
            }

            try
            {
                // Simulate a FormatException
                string input = "abc";
                int number = int.Parse(input);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException: " + ex.Message);
            }
            try
            {
                // Simulate an InvalidOperationException
                throw new InvalidOperationException("This is an InvalidOperationException.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("InvalidOperationException: " + ex.Message);
            }
        }
    }
}
