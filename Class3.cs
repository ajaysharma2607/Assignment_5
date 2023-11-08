using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    partial class Except
    {
        public void Format()
        {
            string s = "Hello";
            try
            {
                int a  = Convert.ToInt32(s);
                Console.WriteLine(a);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
