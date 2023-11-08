using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Except ex = new Except(); 
            ex.ZeroDiv();
            ex.indexout();
            ex.Format();
            ex.Custom();
            ex.Multi();
            ex.inner();
            ex.DivTwo();
            try
            {
                ex.throwExcept(5, 0);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Caught and handled: {e.Message}");
            }

            ex.Cal();



        }
    }
}
