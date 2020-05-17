using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());

            for (int i = 1; i <= limit; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
