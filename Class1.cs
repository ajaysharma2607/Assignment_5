using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    partial class Except
    {
        public void ZeroDiv()
        {
            try
            {
                double a = 10;
                double b = 0;    
                double c = a / b;
                Console.WriteLine(c);
            }
            catch(DivideByZeroException e) 
            {
                Console.WriteLine("Zero Div Error : " + e.Message);
            }

        }
    }
}
