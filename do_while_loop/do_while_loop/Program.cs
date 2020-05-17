using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int limit = int.Parse(Console.ReadLine());

            do //this is practically the same thing lol
            {
                count++;
                Console.WriteLine(count);
            } while (count < limit);
        }
    }
}
