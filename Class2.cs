using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    partial class Except
    {
        public void indexout()
        {
            int[] arr= {1,2,3,4,5 };
            try
            {
                Console.WriteLine(arr[6]);
            }
            catch(IndexOutOfRangeException e) { 
                Console.WriteLine(e.Message);
            }

        }
    }
}
