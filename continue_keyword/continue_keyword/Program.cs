using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continue_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++) // will output 1 3 4 5
            {                                 
                if (i == 2)
                {
                    continue;
                }
                
                Console.WriteLine(i);
            }
        }
    }
}
