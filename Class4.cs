using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    public class Div : Exception
    {
        public Div(string message)
        {
            Console.WriteLine(message); 
        }
       
    }
    partial class Except
    {
        public void Custom()
        {
            int a = 10;
            int b = 0;
           if(b== 0)
            {
                throw new Div("Divide By Exception");
            }
            else
            {
                Console.Write(a/b);
            }
        }

    }
}
